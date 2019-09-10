using System;
using Xamarin.Forms;

namespace Xappy.Content.ControlGallery.ControlTemplates
{
    public partial class ButtonControlTemplate : Frame, IControlTemplate
    {
        
        
        public ButtonControlTemplate()
        {
            InitializeComponent();

            //TargetControl = targetControl;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public View TargetControl { get; set; }
    }
}
