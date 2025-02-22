
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox4;

	private global::Gtk.Label lblTitle;

	private global::Gtk.Table table4;

	private global::Gtk.Button btnCinco;

	private global::Gtk.Button btnDois;

	private global::Gtk.Button btnOito;

	private global::Gtk.Button btnQuatro;

	private global::Gtk.Button btnSeis;

	private global::Gtk.Button btnSete;

	private global::Gtk.Button btnTres;

	private global::Gtk.Button btnUm;

	private global::Gtk.Button btnZero;

	private global::Gtk.VBox vbox5;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label label18;

	private global::Gtk.Label label20;

	private global::Gtk.Label label22;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Label lblResultX;

	private global::Gtk.Label lblResultO;

	private global::Gtk.Label lblReusltEmpate;

	private global::Gtk.Button btnLimpar;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Jogo da Velha");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.lblTitle = new global::Gtk.Label();
		this.lblTitle.Name = "lblTitle";
		this.vbox4.Add(this.lblTitle);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.lblTitle]));
		w1.Position = 0;
		// Container child vbox4.Gtk.Box+BoxChild
		this.table4 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.btnCinco = new global::Gtk.Button();
		this.btnCinco.CanFocus = true;
		this.btnCinco.Name = "btnCinco";
		this.btnCinco.UseUnderline = true;
		this.btnCinco.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnCinco);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table4[this.btnCinco]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.LeftAttach = ((uint)(2));
		w2.RightAttach = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.btnDois = new global::Gtk.Button();
		this.btnDois.CanFocus = true;
		this.btnDois.Name = "btnDois";
		this.btnDois.UseUnderline = true;
		this.btnDois.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnDois);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4[this.btnDois]));
		w3.LeftAttach = ((uint)(2));
		w3.RightAttach = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.btnOito = new global::Gtk.Button();
		this.btnOito.CanFocus = true;
		this.btnOito.Name = "btnOito";
		this.btnOito.UseUnderline = true;
		this.btnOito.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnOito);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4[this.btnOito]));
		w4.TopAttach = ((uint)(2));
		w4.BottomAttach = ((uint)(3));
		w4.LeftAttach = ((uint)(2));
		w4.RightAttach = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.btnQuatro = new global::Gtk.Button();
		this.btnQuatro.CanFocus = true;
		this.btnQuatro.Name = "btnQuatro";
		this.btnQuatro.UseUnderline = true;
		this.btnQuatro.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnQuatro);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table4[this.btnQuatro]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		// Container child table4.Gtk.Table+TableChild
		this.btnSeis = new global::Gtk.Button();
		this.btnSeis.CanFocus = true;
		this.btnSeis.Name = "btnSeis";
		this.btnSeis.UseUnderline = true;
		this.btnSeis.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnSeis);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table4[this.btnSeis]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.btnSete = new global::Gtk.Button();
		this.btnSete.CanFocus = true;
		this.btnSete.Name = "btnSete";
		this.btnSete.UseUnderline = true;
		this.btnSete.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnSete);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4[this.btnSete]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		// Container child table4.Gtk.Table+TableChild
		this.btnTres = new global::Gtk.Button();
		this.btnTres.CanFocus = true;
		this.btnTres.Name = "btnTres";
		this.btnTres.UseUnderline = true;
		this.btnTres.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnTres);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table4[this.btnTres]));
		w8.TopAttach = ((uint)(1));
		w8.BottomAttach = ((uint)(2));
		// Container child table4.Gtk.Table+TableChild
		this.btnUm = new global::Gtk.Button();
		this.btnUm.CanFocus = true;
		this.btnUm.Name = "btnUm";
		this.btnUm.UseUnderline = true;
		this.btnUm.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnUm);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4[this.btnUm]));
		w9.LeftAttach = ((uint)(1));
		w9.RightAttach = ((uint)(2));
		// Container child table4.Gtk.Table+TableChild
		this.btnZero = new global::Gtk.Button();
		this.btnZero.CanFocus = true;
		this.btnZero.Name = "btnZero";
		this.btnZero.UseUnderline = true;
		this.btnZero.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
		this.table4.Add(this.btnZero);
		this.vbox4.Add(this.table4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.table4]));
		w11.Position = 1;
		// Container child vbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 25;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label18 = new global::Gtk.Label();
		this.label18.Name = "label18";
		this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Vitórias X:");
		this.hbox5.Add(this.label18);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label18]));
		w12.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label20 = new global::Gtk.Label();
		this.label20.Name = "label20";
		this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Vitórias 0:");
		this.hbox5.Add(this.label20);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label20]));
		w13.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label22 = new global::Gtk.Label();
		this.label22.Name = "label22";
		this.label22.LabelProp = global::Mono.Unix.Catalog.GetString("Empates:");
		this.hbox5.Add(this.label22);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label22]));
		w14.Position = 2;
		this.vbox5.Add(this.hbox5);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox5]));
		w15.Position = 0;
		w15.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lblResultX = new global::Gtk.Label();
		this.lblResultX.Name = "lblResultX";
		this.lblResultX.LabelProp = global::Mono.Unix.Catalog.GetString("label25");
		this.hbox7.Add(this.lblResultX);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.lblResultX]));
		w16.Position = 0;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lblResultO = new global::Gtk.Label();
		this.lblResultO.Name = "lblResultO";
		this.lblResultO.LabelProp = global::Mono.Unix.Catalog.GetString("label27");
		this.hbox7.Add(this.lblResultO);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.lblResultO]));
		w17.Position = 1;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lblReusltEmpate = new global::Gtk.Label();
		this.lblReusltEmpate.Name = "lblReusltEmpate";
		this.lblReusltEmpate.LabelProp = global::Mono.Unix.Catalog.GetString("label30");
		this.hbox7.Add(this.lblReusltEmpate);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.lblReusltEmpate]));
		w18.Position = 2;
		this.vbox5.Add(this.hbox7);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
		w19.Position = 1;
		// Container child vbox5.Gtk.Box+BoxChild
		this.btnLimpar = new global::Gtk.Button();
		this.btnLimpar.CanFocus = true;
		this.btnLimpar.Name = "btnLimpar";
		this.btnLimpar.UseUnderline = true;
		this.btnLimpar.Label = global::Mono.Unix.Catalog.GetString("Limpar");
		this.vbox5.Add(this.btnLimpar);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.btnLimpar]));
		w20.Position = 2;
		this.vbox4.Add(this.vbox5);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox5]));
		w21.Position = 2;
		this.Add(this.vbox4);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 398;
		this.DefaultHeight = 444;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnZero.Clicked += new global::System.EventHandler(this.ClickZero);
		this.btnUm.Clicked += new global::System.EventHandler(this.ClickUm);
		this.btnTres.Clicked += new global::System.EventHandler(this.ClickTres);
		this.btnSete.Clicked += new global::System.EventHandler(this.ClickSete);
		this.btnSeis.Clicked += new global::System.EventHandler(this.ClickSeis);
		this.btnQuatro.Clicked += new global::System.EventHandler(this.ClickQuatro);
		this.btnOito.Clicked += new global::System.EventHandler(this.ClickOito);
		this.btnDois.Clicked += new global::System.EventHandler(this.ClickDois);
		this.btnCinco.Clicked += new global::System.EventHandler(this.ClickCinco);
		this.btnLimpar.Clicked += new global::System.EventHandler(this.ClickLimpar);
	}
}
