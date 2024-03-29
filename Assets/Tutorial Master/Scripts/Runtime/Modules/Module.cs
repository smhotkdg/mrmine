using System;
using UnityEngine;

namespace HardCodeLab.TutorialMaster
{
    /// <inheritdoc />
    /// <summary>
    /// Superclass for a Module component. Has basic functions like placing itself within a Canvas.
    /// </summary>
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class Module : MonoBehaviour
    {
        /// <summary>
        /// Initial transform of a parent
        /// </summary>
        protected Transform DefaultParent;

        /// <summary>
        /// RectTransform Component of this Module.
        /// </summary>
        protected RectTransform RectTransform;

        /// <summary>
        /// Stores the current settings of this Module.
        /// </summary>
        private ModuleSettings _currentSettings;

        /// <summary>
        /// Gets a value indicating whether or not this Module is in use.
        /// </summary>
        public bool InUse { get; private set; }

        /// <summary>
        /// Destination position of this Module
        /// </summary>
        protected Vector2 DestinationPosition { get; private set; }

        /// <summary>
        /// Gets the current language key of this Module.
        /// </summary>
        protected string CurrentLanguageKey { get; private set; }

        /// <summary>
        /// The TutorialMasterManager object that currently control this Module.
        /// </summary>
        protected TutorialMasterManager CallerManager { get; private set; }

        /// <summary>
        /// Current Canvas that this Module is residing in. If it's not active, then this will be null
        /// </summary>
        protected Canvas CurrentCanvas { get; private set; }

        /// <summary>
        /// RectTransform component for a current Canvas
        /// </summary>
        protected RectTransform CurrentCanvasTransform { get; private set; }

        /// <summary>
        /// Returns true if this Module can make changes every frame.
        /// </summary>
        public bool UpdateEveryFrame
        {
            get
            {
                if (!InUse)
                    return false;

                if (_currentSettings == null)
                    return false;

                if (!_currentSettings.UpdateEveryFrame)
                    return false;

                return true;
            }
        }

        /// <summary>
        /// Position of the Module in relation to the canvas it resides in.
        /// It's an accurate position of the Module regardless of its current canvas setup or parent it's in.
        /// </summary>
        /// <value>
        /// The module position.
        /// </value>
        protected Vector2 ModulePosition { get; private set; }

        /// <summary>
        /// Accurate size of the module.
        /// </summary>
        protected Vector2 ModuleSize { get; private set; }

        /// <summary>
        /// The default scale of the module transform
        /// </summary>
        protected Vector3 DefaultModuleScale { get; private set; }

        /// <summary>
        /// Gets the current module settings.
        /// </summary>
        /// <typeparam name="TSettings">The type of the settings.</typeparam>
        /// <returns>Module settings</returns>
        public TSettings GetSettings<TSettings>()
            where TSettings : ModuleSettings
        {
            return _currentSettings as TSettings;
        }

        /// <summary>
        /// Activates the functions of this Module
        /// </summary>
        /// <param name="caller">TutorialMasterManager that called this Module.</param>
        /// <param name="settings">The Effect Settings.</param>
        /// <param name="languageKey">Id of the language.</param>
        public void Activate(TutorialMasterManager caller, ModuleSettings settings, string languageKey = "")
        {
            if (!InUse)
            {
                TMLogger.LogInfo(string.Format("Activating {0} of name \"{1}\"...", GetType().Name, gameObject.name), this);

                _currentSettings = settings;

                if (NullChecker.IsNull(_currentSettings.TargetCanvas, "TargetCanvas has not been assigned! Aborting activation...", this))
                    return;

                CurrentCanvas = _currentSettings.TargetCanvas;
                CurrentCanvasTransform = CurrentCanvas.GetComponent<RectTransform>();

                CallerManager = caller;

                UpdateParent();
                RecalculateModuleRect();
                SetLanguage(languageKey);

                CalculateTransform();
                ApplyTransform();

                OnModuleActivated();

                AddEffects();
                InUse = true;
            }
            else
            {
                TMLogger.LogInfo(string.Format("Module of the name \"{0}\" is already in use by Tutorial Master GameObject named \"{1}\". Ignoring...",
                    gameObject.name, CallerManager.gameObject.name), this);
            }
        }

        /// <summary>
        /// Deactivates this Module.
        /// </summary>
        public void Deactivate()
        {
            TMLogger.LogInfo("Deactivating this Module...", this);

            if (!InUse)
            {
                TMLogger.LogInfo("This Module isn't used. No deactivation necessary. Ignoring...", this);
                return;
            }

            ResetParent();
            RemoveEffects();

            OnModuleDeactivated();

            InUse = false;
            _currentSettings = null;
            CurrentCanvas = null;

            TMLogger.LogInfo("Deactivation complete!", this);
        }

        /// <summary>
        /// Updates this Module's localized content to a new language.
        /// </summary>
        /// <param name="languageKey">Unique key of a language which will be set for this Module.</param>
        public virtual void SetLanguage(string languageKey)
        {
            // this method is empty because not all modules need to be affected by language changes
            TMLogger.LogInfo(string.Format("Applying language changes for this module. Key: {0}", languageKey), this);
            CurrentLanguageKey = languageKey;
        }

        /// <summary>
        /// Called every OnUpdate call if enabled
        /// </summary>
        protected virtual void OnUpdate()
        {
            RecalculateModulePosition();
            CalculateTransform();
            ApplyTransform();
        }

        /// <summary>
        /// Gets the accurate position of a given RectTransform in relation of the canvas it resides in
        /// Unlike other means of obtaining the position, this method will give an accurate position regardless how nested it is or what canvas type it is.
        /// </summary>
        /// <param name="target">RectTransform from which position will be calculated.</param>
        /// <param name="canvas">The Canvas where RectTransform resides in.</param>
        /// <returns>Calculated vector representing the position of the UI Element.</returns>
        public static Vector2 GetAccuratePosition(RectTransform target, Canvas canvas)
        {
            var calculatedPosition = new Vector3();
            var currentParent = target;

            while (currentParent.parent != null)
            {
                calculatedPosition += currentParent.localPosition;
                currentParent = currentParent.parent.GetComponent<RectTransform>();
            }

            return calculatedPosition;
        }

        /// <summary>
        /// Calculates the position from a given Canvas.
        /// </summary>
        /// <returns>Vector representing a newly calculated position</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected Vector2 CalculatePositionFromCanvas()
        {
            TMLogger.LogInfo(string.Format("Calculating a position based on placement of type \"{0}\" based on a RectTransform of {1}",
                _currentSettings.PlacementType,
                _currentSettings.UITarget.gameObject.name), this);

            Vector2 targetSize = RectTransformUtility.PixelAdjustRect(_currentSettings.UITarget, CurrentCanvas).size;

            var targetPosition = GetAccuratePosition(_currentSettings.UITarget, CurrentCanvas);

            Vector2 newPosition = targetPosition;

            switch (_currentSettings.PlacementType)
            {
                case PlacementType.Center:

                    // no action needed because this module already been positioned properly

                    break;

                case PlacementType.Top:

                    newPosition = new Vector2(
                        newPosition.x,
                        newPosition.y + (targetSize.y / 2) + (ModuleSize.y / 2)
                        );

                    break;

                case PlacementType.Bottom:

                    newPosition = new Vector2(
                        newPosition.x,
                        newPosition.y - (targetSize.y / 2) - (ModuleSize.y / 2)
                    );

                    break;

                case PlacementType.Left:

                    newPosition = new Vector2(
                        newPosition.x - (targetSize.x / 2) - (ModuleSize.x / 2),
                        newPosition.y
                    );

                    break;

                case PlacementType.Right:

                    newPosition = new Vector2(
                        newPosition.x + (targetSize.x / 2) + (ModuleSize.x / 2),
                        newPosition.y
                    );

                    break;

                case PlacementType.TopLeft:

                    newPosition = new Vector2(
                        newPosition.x - (targetSize.x / 2) - (ModuleSize.x / 2),
                        newPosition.y + (targetSize.y / 2) + (ModuleSize.y / 2)
                    );

                    break;

                case PlacementType.TopRight:

                    newPosition = new Vector2(
                        newPosition.x + (targetSize.x / 2) + (ModuleSize.x / 2),
                        newPosition.y + (targetSize.y / 2) + (ModuleSize.y / 2)
                    );

                    break;

                case PlacementType.BottomLeft:

                    newPosition = new Vector2(
                        newPosition.x - (targetSize.x / 2) - (ModuleSize.x / 2),
                        newPosition.y - (targetSize.y / 2) - (ModuleSize.y / 2)
                    );

                    break;

                case PlacementType.BottomRight:

                    newPosition = new Vector2(
                        newPosition.x + (targetSize.x / 2) + (ModuleSize.x / 2),
                        newPosition.y - (targetSize.y / 2) - (ModuleSize.y / 2)
                    );

                    break;

                default:

                    throw TMLogger.LogException(new ArgumentOutOfRangeException());
            }

            TMLogger.LogInfo(string.Format("Placement calculated! New position is {0}", newPosition), this);

            return newPosition;
        }

        protected Vector2 CalculatePositionFromWorld(Vector3 position)
        {
            TMLogger.LogInfo(string.Format("Converting a position of {0} in order to position it within the canvas space...", position), this);

            var pos = Camera.main.WorldToViewportPoint(position);

            var newPosition = new Vector2(
                (pos.x * CurrentCanvasTransform.sizeDelta.x) - (CurrentCanvasTransform.sizeDelta.x * 0.5f),
                (pos.y * CurrentCanvasTransform.sizeDelta.y) - (CurrentCanvasTransform.sizeDelta.y * 0.5f)
            );

            TMLogger.LogInfo(string.Format("Canvas-space position has been calculated! It's {0}", newPosition), this);

            return newPosition;
        }

        /// <summary>
        /// Called only once.
        /// </summary>  
        protected virtual void Awake()
        {
            TMLogger.LogInfo("Assigning RectTransform and storing reference to its initial parent...", this);
            RectTransform = GetComponent<RectTransform>();
            DefaultModuleScale = RectTransform.localScale;
            DefaultParent = RectTransform.parent;
        }

        /// <summary>
        /// Called after this Module is deactivated.
        /// </summary>
        protected abstract void OnModuleDeactivated();

        /// <summary>
        /// Called after this Module is activated. 
        /// </summary>
        protected abstract void OnModuleActivated();

        /// <summary>
        /// Recalculates only the position of the Module.
        /// </summary>
        protected void RecalculateModulePosition()
        {
            ModulePosition = RectTransformUtility.PixelAdjustPoint(RectTransform.localPosition, RectTransform, CurrentCanvas);
        }

        /// <summary>
        /// Recalculates only the size of the Module.
        /// </summary>
        protected void RecalculateModuleSize()
        {
            ModuleSize = RectTransformUtility.PixelAdjustRect(RectTransform, CurrentCanvas).size;
        }

        /// <summary>
        /// Recalculates the module rect (position and size) based on a current canvas. Operation can be costly.
        /// </summary>
        protected void RecalculateModuleRect()
        {
            RecalculateModulePosition();
            RecalculateModuleSize();
        }

        /// <summary>
        /// Called every frame.
        /// </summary>
        private void LateUpdate()
        {
            if (!UpdateEveryFrame)
                return;

            OnUpdate();
        }

        /// <summary>
        /// Calculates the end position for this Module
        /// </summary>
        private void CalculateTransform()
        {
            if (_currentSettings.PositionMode == PositionMode.TransformBased)
            {
                if (_currentSettings.TargetType == TargetType.CanvasSpace)
                {
                    DestinationPosition = CalculatePositionFromCanvas();
                }
                else if (_currentSettings.TargetType == TargetType.WorldSpace)
                {
                    DestinationPosition = CalculatePositionFromWorld(_currentSettings.TransformTarget.position);
                }
            }
            else
            {
                DestinationPosition = _currentSettings.CustomPosition;
            }

            ApplyPositionOffset();

            if (_currentSettings.ConstrainToCanvas)
            {
                DestinationPosition = ConstrainToCanvas(DestinationPosition, _currentSettings.ConstrainPadding);
            }
        }

        /// <summary>
        /// Applies the calculated position values to this Module RectTransform.
        /// </summary>
        private void ApplyTransform()
        {
            RectTransform.anchoredPosition = DestinationPosition;
        }

        /// <summary>
        /// Applies the position offset to the Destination Position.
        /// </summary>
        private void ApplyPositionOffset()
        {
            DestinationPosition += _currentSettings.PositionOffset;
        }

        /// <summary>
        /// Returns the constrained position of the module within the boundaries of canvas
        /// </summary>
        /// <returns>Vector2 representing a constrained position</returns>
        private Vector2 ConstrainToCanvas(Vector2 pos, Borders offset)
        {
            TMLogger.LogInfo("Calculating a clamped position for this Module...", this);

            var canvasSize = RectTransformUtility.PixelAdjustRect(RectTransform.parent.GetComponent<RectTransform>(), CurrentCanvas).size;

            // get the bottom left corner of the canvas
            var minPos = new Vector2(
                    (ModuleSize.x / 2) - (canvasSize.x / 2) + offset.Left,
                    (ModuleSize.y / 2) - (canvasSize.y / 2) + offset.Bottom
                );

            // get the top right corner of the canvas
            var maxPos = new Vector2(
                -(ModuleSize.x / 2) + (canvasSize.x / 2) - offset.Right,
                -(ModuleSize.y / 2) + (canvasSize.y / 2) - offset.Top
                );

            var newPosition = new Vector2(
                    Mathf.Clamp(pos.x, minPos.x, maxPos.x),
                    Mathf.Clamp(pos.y, minPos.y, maxPos.y)
                );

            TMLogger.LogInfo(string.Format("Clamped position calculated! It's a {0}", newPosition), this);

            return newPosition;
        }

        /// <summary>
        /// Executes any effects which are set to be enabled for this Module.
        /// </summary>
        private void AddEffects()
        {
            TMLogger.LogInfo("Adding effects...", this);

            AddEffect<FlyInEffect, FlyInEffectSettings>(_currentSettings.FlyInEffectSettings);
            AddEffect<FadeInEffect, FadeInEffectSettings>(_currentSettings.FadeInEffectSettings);
            AddEffect<ScalePulsingEffect, ScalePulsingEffectSettings>(_currentSettings.ScalePulsingEffectSettings);
            AddEffect<FloatEffect, FloatEffectSettings>(_currentSettings.FloatEffectSettings);

            TMLogger.LogInfo("Finished adding all effects!", this);
        }

        /// <summary>
        /// Adds an effect to this Module if needed.
        /// </summary>
        /// <typeparam name="TEffect">The type of the effect.</typeparam>
        /// <typeparam name="TEffectSettings">The type of the effect setting.</typeparam>
        /// <param name="effectSettings">The effect settings.</param>
        private void AddEffect<TEffect, TEffectSettings>(TEffectSettings effectSettings)
            where TEffectSettings : EffectSettings
            where TEffect : Effect<TEffectSettings>
        {
            if (!effectSettings.IsEnabled) return;

            TMLogger.LogInfo(string.Format("Adding an effect \"{0}\"...", typeof(TEffect).Name), this);

            gameObject.AddComponent<TEffect>().SetEffectSettings(effectSettings);

            TMLogger.LogInfo(string.Format("Effect \"{0}\" has been added!", typeof(TEffect).Name), this);
        }

        /// <summary>
        /// Disables any active effects.
        /// </summary>
        private void RemoveEffects()
        {
            TMLogger.LogInfo("Removing all effects...", this);

            Destroy(GetComponent<FlyInEffect>());
            Destroy(GetComponent<FadeInEffect>());
            Destroy(GetComponent<ScalePulsingEffect>());
            Destroy(GetComponent<FloatEffect>());

            TMLogger.LogInfo("All effects removed.", this);
        }

        /// <summary>
        /// Updates the parent of this Module as sets it to be on the top.
        /// </summary>
        private void UpdateParent()
        {
            TMLogger.LogInfo("Assigning a new parent for the Module...", this);

            if (NullChecker.IsNull(_currentSettings.TargetCanvas, "Unable to assign a parent! TargetCanvas has not been assigned.", this))
                return;

            var newParent = _currentSettings.TargetCanvas.transform;

            if (NullChecker.IsNull(RectTransform, "RectTransform is null! Unable to assign a parent. Ignoring...", this))
                return;

            RectTransform.SetParent(newParent);
            RectTransform.SetAsLastSibling();
            RectTransform.localScale = DefaultModuleScale;

            TMLogger.LogInfo("New parent successfully assigned!", this);
        }

        /// <summary>
        /// Resets the parent of this Module to its default parent
        /// </summary>
        private void ResetParent()
        {
            TMLogger.LogInfo("Moving this Module back to the original parent", this);
            RectTransform.SetParent(DefaultParent);
            TMLogger.LogInfo("Module parent has been reset to original parent", this);
        }
    }
}