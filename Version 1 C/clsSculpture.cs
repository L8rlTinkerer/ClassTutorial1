using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static frmSculpture _PaintDialog;

        public override void EditDetails()
        {
            if (_PaintDialog == null)
            {
                _PaintDialog = new frmSculpture();
            }
            _PaintDialog.SetDetails(_Name, _Date, _Value, _Weight, _Material);
            if (_PaintDialog.ShowDialog() == DialogResult.OK)
            {
                _PaintDialog.GetDetails(ref _Name, ref _Date, ref _Value, ref _Weight, ref _Material);
            }

        }
    }
}
