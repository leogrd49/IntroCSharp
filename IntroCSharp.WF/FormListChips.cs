using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCSharp.WF;

public partial class FormListChips : Form
{

    public List<string> ListChips { get; set; }

    /// <summary>
    /// Constructeur de la fenetre
    /// </summary>
    public FormListChips()
    {
        ListChips = new List<string>();
        ListChips.Add("Barbecue");
        ListChips.Add("Poulet");
        ListChips.Add("Bolognaise");
        ListChips.Add("Parprika");
        ListChips.Add("Crème Oignon");
        ListChips.Add("Hot & Spicy");
        InitializeComponent();
        ListBoxChips.DataSource = ListChips;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
