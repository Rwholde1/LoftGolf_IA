using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoftGolfOverlayUI
{
    public partial class MovieBG : Form
    {
        private Dictionary<string, string> scriptFileDict;
        public MovieBG()
        {
            InitializeComponent();
            scriptFileDict = Program.retrieveDict();
            string bgImg = scriptFileDict["MovieBGImg"];
            label1.Image = Image.FromFile(bgImg);
        }
    }
}
