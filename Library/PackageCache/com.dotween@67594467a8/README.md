DOTween and DOTween Pro are copyright (c) 2014-2018 Daniele Giardini - Demigiant

// UPM PACKAGE NOTES ///////////////////////////////////////////

This fork is packaged for the Unity Package Manager (Runtime/Editor asmdef split, package.json).
Because packages installed via UPM (git URL, registry, etc.) are read-only, the original
"Setup DOTween..." Utility Panel can no longer flip modules on/off by rewriting files inside
the package. Module toggles are now driven by real scripting define symbols instead:

- DOTUI, DOTPHYSICS, DOTPHYSICS2D, DOTAUDIO, DOTSPRITE: set automatically via Version Defines
  when the corresponding built-in Unity module (com.unity.modules.ui / .physics / .physics2d / .audio)
  is present in the project - no action needed.
- DOTWEEN_TMP: set automatically via Version Defines when the "com.unity.textmeshpro" package
  is installed - this is what enables DOTweenPro's TextMeshPro support (DOTweenAnimation TMP
  targets, ShortcutExtensionsTMPText, etc).
- DOTWEEN_TK2D (2D Toolkit) and EPO_DOTWEEN (Easy Performant Outline) have no UPM package to
  detect, since they're third-party Asset Store add-ons: add the define manually under
  Project Settings > Player > Scripting Define Symbols if you use them.

// IMPORTANT!!! /////////////////////////////////////////////
// Upgrading DOTween from versions older than 1.2.000 ///////
// (or DOTween Pro older than 1.0.000) //////////////////////
-------------------------------------------------------------
If you're upgrading your project from a version of DOTween older than 1.2.000 (or DOTween Pro older than 1.0.000) please follow these instructions carefully.
1) Import the new version in the same folder as the previous one, overwriting old files. A lot of errors will appear but don't worry
2) Close and reopen Unity (and your project). This is fundamental: skipping this step will cause a bloodbath
3) Open DOTween's Utility Panel (Tools > Demigiant > DOTween Utility Panel) if it doesn't open automatically, then press "Setup DOTween...": this will run the upgrade setup
4) From the Add/Remove Modules panel that opens, activate/deactivate Modules for Unity systems and for external assets (like TextMesh Pro)

// GET STARTED //////////////////////////////////////////////

- After importing a new DOTween update, select DOTween's Utility Panel from the "Tools/Demigiant" menu (if it doesn't open automatically) and press the "Setup DOTween..." button to activate/deactivate Modules. You can also access a Preferences Tab from there to choose default settings for DOTween.

// VISUAL SCRIPTING (PRO ONLY)
- To animate a gameObject, select it and choose "Add Component > DOTween > DOTween Animation"
- To animate a gameObject along a path, select it and choose "Add Component > DOTween > DOTween Path"

// SCRIPTING
- In your code, add "using DG.Tweening" to each class where you want to use DOTween.
- You're ready to tween. Check out the links below for full documentation and license info.


// LINKS ///////////////////////////////////////////////////////

DOTween website (documentation, examples, etc): http://dotween.demigiant.com
DOTween license: http://dotween.demigiant.com/license.php
DOTween repository (Google Code): https://code.google.com/p/dotween/
Demigiant website (documentation, examples, etc): http://www.demigiant.com

// NOTES //////////////////////////////////////////////////////

- DOTween's Utility Panel can be found under "Tools > Demigiant > DOTween Utility Panel" and also contains other useful options, plus a tab to set DOTween's preferences