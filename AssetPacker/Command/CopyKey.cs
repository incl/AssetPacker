using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class CopyKey : ICommand
    {
        private MainForm form;

        public CopyKey(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.project != null;
        }

        public void Execute()
        {
            if (!Check())
                return;

            Clipboard.SetText(form.txtPrivateKey.Text);

            form.labelCopy.Visible = true;
            Timer timer = new Timer()
            {
                Interval = 2000
            };
            timer.Tick += (sender, e) =>
            {
                ((Timer)sender).Stop();
                form.labelCopy.Visible = false;
            };
            timer.Start();
        }
    }
}
