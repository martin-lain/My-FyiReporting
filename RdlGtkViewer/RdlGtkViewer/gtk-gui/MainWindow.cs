
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table1;
	private global::fyiReporting.RdlGtkViewer.RdlGtkViewer rdlgtkviewer1;
    
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.rdlgtkviewer1 = new global::fyiReporting.RdlGtkViewer.RdlGtkViewer ();
		this.rdlgtkviewer1.Events = ((global::Gdk.EventMask)(256));
		this.rdlgtkviewer1.Name = "rdlgtkviewer1";
		this.table1.Add (this.rdlgtkviewer1);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.rdlgtkviewer1]));
		w1.TopAttach = ((uint)(1));
		w1.BottomAttach = ((uint)(2));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		this.Add (this.table1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 487;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
