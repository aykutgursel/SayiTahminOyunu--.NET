using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Random Rsayi = new Random();

    private int RasgeleSayi
    {
        get
        {
            if (ViewState["RasgeleSayi"] != null)
            {
                return ((int)ViewState["RasgeleSayi"]);
            }
            else
            {
                ViewState["RasgeleSayi"] = 0;
                return 0;
            }
        }
        set
        {
            ViewState["RasgeleSayi"] = value;
        }
    }

    private int KalanHak
    {
        get
        {
            if (ViewState["KalanHak"] != null)
            {
                return ((int)ViewState["KalanHak"]);
            }
            else
            {
                ViewState["KalanHak"] = 0;
                return 0;
            }
        }
        set
        {
            ViewState["KalanHak"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            RasgeleSayi = Rsayi.Next(0, 50);
            KalanHak = 5;
            lblHak.Text = "Kalan Hakkınız : " + KalanHak.ToString();
            lblDurum.Text = "";
        }

    }
    protected void btnTahmin_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(TxSayi.Text))
        {

            if (Convert.ToInt32(TxSayi.Text) < RasgeleSayi)
            {
                lblDurum.Text = "Sonuç biraz daha büyük";
                KalanHak--;
            }

            if (Convert.ToInt32(TxSayi.Text) > RasgeleSayi)
            {
                lblDurum.Text = "Sonuç biraz küçük";
                KalanHak--;
            }

            if (Convert.ToInt32(TxSayi.Text) == RasgeleSayi)
            {
                lblDurum.Text = "TEBRIKLER! Cevabı "+KalanHak.ToString()+" hakkın kala buldun";
                btnRestart.Enabled = true;
                btnTahmin.Enabled = false;
            }

            if (KalanHak == 0)
            {
                lblDurum.Text = "Hakkınız Kalmadı. Sonuç : "+RasgeleSayi;
                btnRestart.Enabled = true;
                btnTahmin.Enabled = false;
            }

            lblHak.Text = "Kalan Hakkınız : " + KalanHak.ToString();
            SonTahmin.Text = "Son Tahmininiz : " + TxSayi.Text;
            TxSayi.Text = string.Empty;

        }

    }
    protected void btnRestart_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

}