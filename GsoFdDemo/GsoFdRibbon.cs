using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GsoFdDemo
{
    public partial class GsoFdRibbon
    {
        private void GsoFdRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            GsoFdRibbonTab.RibbonUI.ActivateTab("GsoFdRibbonTab");
        }

        private void GsoFdRbnBtnDisplayForm_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisWorkbook.frm = new frmGsoFd();
            Globals.ThisWorkbook.frm.Show();

            Globals.Ribbons.GsoFdRibbon.GsoFdRbnBtnDisplayForm.Enabled = false;


        }
    }
}
