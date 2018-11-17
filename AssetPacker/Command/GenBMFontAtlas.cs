using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class GenBMFontAtlas : ICommand
    {
        private MainForm form;

        public GenBMFontAtlas(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.listAssets.SelectedIndices.Count > 0;
        }

        public void Execute()
        {
            if (!Check())
                return;

            form.RunMakeAtlas(false);
        }
    }
}
