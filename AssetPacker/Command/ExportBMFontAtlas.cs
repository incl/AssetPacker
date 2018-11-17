using System.Windows.Forms;

namespace AssetPacker.Command
{
    public class ExportBMFontAtlas : ICommand
    {
        private MainForm form;

        public ExportBMFontAtlas(MainForm form)
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

            if (form.listAssets.SelectedIndices.Count == 0)
                return;

            Model.Asset asset = form.project.Assets[form.listAssets.SelectedIndices[0]];
            if (asset.Atlas == null)
                return;

            var dlg = new SaveFileDialog()
            {
                Filter = "png files|*png",
            };
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string savename = dlg.FileName;
                if (System.IO.Path.HasExtension(savename))
                {
                    savename = System.IO.Path.ChangeExtension(savename, "");
                }
                else
                {
                    savename += ".";
                }
                asset.Atlas.SaveImage(savename + "png");
                asset.Atlas.SaveFnt(savename + "fnt");
            }
        }
    }
}
