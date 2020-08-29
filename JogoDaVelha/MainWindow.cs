using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    // 0 = X   and   1 = O
    int[] casas = new int[9];
    int pedra = 0;
    string title = "";
    int jogoX = 0;
    int jogoO = 0;
    int jogoEmpate = 0;

    private void Limpar()
    {
        this.jogoX = 0;
        this.jogoO = 0;
        this.jogoEmpate = 0;
        this.Start();
    }
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        this.Start(); 
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void VerTitle()
    {
        title = $"Start Game ({this.VerTipo(this.pedra)})";
    }

    private void Start()
    {
        this.VerTitle();
        this.StartCasas();

        this.lblTitle.Text = this.title;
        this.pedra = 0;
        this.lblResultX.Text = jogoX.ToString();
        this.lblReusltEmpate.Text = jogoEmpate.ToString();
        this.lblResultO.Text = jogoO.ToString();

        this.btnZero.Label = "";
        this.btnUm.Label = "";
        this.btnDois.Label = "";
        this.btnTres.Label = "";
        this.btnQuatro.Label = "";
        this.btnCinco.Label = "";
        this.btnSeis.Label = "";
        this.btnSete.Label = "";
        this.btnOito.Label = "";
    }



    private void StartCasas()
    {
        for(int x = 0; x < casas.Length; x++)
        {
            casas[x] = 3;
        }
    }

    private void TudoPreenchido()
    {
        int count = 0;
        for (int x = 0; x < casas.Length; x++)
        {
            if (casas[x] == 3)
                count++;
        }
        if (count == 0)
        {
            this.jogoEmpate++;
            this.Msg($"Ninguem ganhou, EMPATE!");
            this.Start();
        }
    }

    private string VerTipo(int verPedra)
    {
        return verPedra == 0 ? "X" : "O";
    }

    protected void ClickZero(object sender, EventArgs e)
    {
        if(casas[0] == 3)
        {
            casas[0] = pedra;
            this.btnZero.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickUm(object sender, EventArgs e)
    {
        if (casas[1] == 3)
        {
            casas[1] = pedra;
            this.btnUm.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickDois(object sender, EventArgs e)
    {
        if (casas[2] == 3)
        {
            casas[2] = pedra;
            this.btnDois.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickTres(object sender, EventArgs e)
    {
        if (casas[3] == 3)
        {
            casas[3] = pedra;
            this.btnTres.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickQuatro(object sender, EventArgs e)
    {
        if (casas[4] == 3)
        {
            casas[4] = pedra;
            this.btnQuatro.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickCinco(object sender, EventArgs e)
    {
        if (casas[5] == 3)
        {
            casas[5] = pedra;
            this.btnCinco.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickSeis(object sender, EventArgs e)
    {
        if (casas[6] == 3)
        {
            casas[6] = pedra;
            this.btnSeis.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickOito(object sender, EventArgs e)
    {
        if (casas[8] == 3)
        {
            casas[8] = pedra;
            this.btnOito.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickSete(object sender, EventArgs e)
    {
        if (casas[7] == 3)
        {
            casas[7] = pedra;
            this.btnSete.Label = this.VerTipo(this.pedra);
            pedra = (pedra == 0 ? 1 : 0);
            this.Analise();
        }
    }

    protected void ClickLimpar(object sender, EventArgs e)
    {
        this.Limpar();
    }

    private void Analise()
    {
        string venceu = "";
        // 1 - 4 - 7
        if (casas[1] == 1  && casas[4] == 1 && casas[7] == 1 )
        {
            jogoO++; 
            //this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[1] == 0 && casas[4] == 0 && casas[7] == 0)
        {
            jogoX++;
            //this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 0 - 3 - 6
        if (casas[0] == 1 && casas[3] == 1 && casas[6] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[0] == 0 && casas[3] == 0 && casas[6] == 0)
        {
            jogoX++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 2 - 5 - 8
        if (casas[2] == 1 && casas[5] == 1 && casas[8] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[2] == 0 && casas[5] == 0 && casas[8] == 0)
        {
            jogoX++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 0 - 1 - 2
        if (casas[0] == 1 && casas[1] == 1 && casas[2] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString(); ;
            venceu = "O";
        }
        if (casas[0] == 0 && casas[1] == 0 && casas[2] == 0)
        {
            jogoO++;
            this.lblResultX.Text = jogoO.ToString();
            venceu = "X";
        }
        // 3 - 4 - 5
        if (casas[3] == 1 && casas[4] == 1 && casas[5] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[3] == 0 && casas[4] == 0 && casas[5] == 0)
        {
            jogoX++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 6 - 7 - 8
        if (casas[6] == 1 && casas[7] == 1 && casas[8] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[6] == 0 && casas[7] == 0 && casas[8] == 0)
        {
            jogoX ++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 0 - 4 - 8
        if (casas[0] == 1 && casas[4] == 1 && casas[8] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[0] == 0 && casas[4] == 0 && casas[8] == 0)
        {
            jogoX++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }
        // 2 - 4 - 6
        if (casas[2] == 1 && casas[4] == 1 && casas[6] == 1)
        {
            jogoO++;
            this.lblResultO.Text = jogoO.ToString();
            venceu = "O";
        }
        if (casas[2] == 0 && casas[4] == 0 && casas[6] == 0)
        {
            jogoX++;
            this.lblResultX.Text = jogoX.ToString();
            venceu = "X";
        }

        if (!venceu.Equals(""))
        {
            this.Msg($"O jogador {venceu} vencem essa partida!");
            this.Start();
        }

        this.VerTitle();
        this.lblTitle.Text = this.title;

        this.TudoPreenchido();
    }

    private void Msg(string mensagem)
    {
        MessageDialog md = new MessageDialog(
            this,
            DialogFlags.DestroyWithParent,
            MessageType.Info, ButtonsType.Ok, mensagem);

        md.SetPosition(Gtk.WindowPosition.CenterOnParent);
        md.Run();
        md.Destroy();
    }
}
