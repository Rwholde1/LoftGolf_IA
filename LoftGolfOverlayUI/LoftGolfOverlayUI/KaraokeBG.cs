using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoftGolfOverlayUI
{
    public partial class KaraokeBG : Form
    {
        private Dictionary<string, string> scriptFileDict;
        public KaraokeBG()
        {
            InitializeComponent();
            scriptFileDict = Program.retrieveDict();
            string bgImg = scriptFileDict["KaraokeBGImg"];
            Debug.WriteLine(bgImg);
            this.BackgroundImage = Image.FromFile(bgImg);
        }
    }
}
