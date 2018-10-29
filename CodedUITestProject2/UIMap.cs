namespace CodedUITestProject2
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public partial class UIMap
    {
        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        /// 
        public void ModifiedSampleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            // Launch '%USERPROFILE%\source\repos\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(45, 6));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(28, 15));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\Space\\source\\repos\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\SimpleWPFApp\SimpleWPFApp\bin\Debug\SimpleWPFApp.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\SimpleWPFApp\\SimpleWPFApp\\bin\\Debug\\SimpleWPFApp.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
