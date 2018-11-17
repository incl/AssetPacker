using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class GenSpriteAtlas : ICommand
    {
        private MainForm form;

        public GenSpriteAtlas(MainForm form)
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

            form.RunMakeAtlas(true);
        }
    }
}
