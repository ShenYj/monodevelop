// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.IPhone.Gui {
    
    
    internal partial class IPhoneSigningKeyPanelWidget {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Label label5;
        
        private Gtk.Alignment alignment2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.CheckButton enableSigningCheck;
        
        private Gtk.Alignment alignment3;
        
        private Gtk.Table signingTable;
        
        private MonoDevelop.Core.Gui.Components.MenuButtonEntry additionalArgsEntry;
        
        private MonoDevelop.Projects.Gui.ProjectFileEntry entitlementsEntry;
        
        private Gtk.ComboBox identityCombo;
        
        private Gtk.Label label4;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label label8;
        
        private Gtk.Label label9;
        
        private Gtk.ComboBox provisioningCombo;
        
        private MonoDevelop.Projects.Gui.ProjectFileEntry resourceRulesEntry;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget";
            // Container child MonoDevelop.IPhone.Gui.IPhoneSigningKeyPanelWidget.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("<b>Application Signing</b>");
            this.label5.UseMarkup = true;
            this.vbox1.Add(this.label5);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.label5]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.alignment2 = new Gtk.Alignment(0F, 0.5F, 1F, 1F);
            this.alignment2.Name = "alignment2";
            this.alignment2.LeftPadding = ((uint)(24));
            // Container child alignment2.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.enableSigningCheck = new Gtk.CheckButton();
            this.enableSigningCheck.CanFocus = true;
            this.enableSigningCheck.Name = "enableSigningCheck";
            this.enableSigningCheck.Label = Mono.Unix.Catalog.GetString("_Sign the application bundle");
            this.enableSigningCheck.DrawIndicator = true;
            this.enableSigningCheck.UseUnderline = true;
            this.vbox3.Add(this.enableSigningCheck);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox3[this.enableSigningCheck]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.alignment3 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment3.Name = "alignment3";
            this.alignment3.LeftPadding = ((uint)(24));
            // Container child alignment3.Gtk.Container+ContainerChild
            this.signingTable = new Gtk.Table(((uint)(5)), ((uint)(2)), false);
            this.signingTable.Name = "signingTable";
            this.signingTable.RowSpacing = ((uint)(6));
            this.signingTable.ColumnSpacing = ((uint)(6));
            // Container child signingTable.Gtk.Table+TableChild
            this.additionalArgsEntry = new MonoDevelop.Core.Gui.Components.MenuButtonEntry();
            this.additionalArgsEntry.Name = "additionalArgsEntry";
            this.signingTable.Add(this.additionalArgsEntry);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.signingTable[this.additionalArgsEntry]));
            w3.TopAttach = ((uint)(4));
            w3.BottomAttach = ((uint)(5));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(0));
            // Container child signingTable.Gtk.Table+TableChild
            this.entitlementsEntry = new MonoDevelop.Projects.Gui.ProjectFileEntry();
            this.entitlementsEntry.Name = "entitlementsEntry";
            this.entitlementsEntry.EntryIsEditable = false;
            this.signingTable.Add(this.entitlementsEntry);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.signingTable[this.entitlementsEntry]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.YOptions = ((Gtk.AttachOptions)(0));
            // Container child signingTable.Gtk.Table+TableChild
            this.identityCombo = new Gtk.ComboBox();
            this.identityCombo.Name = "identityCombo";
            this.signingTable.Add(this.identityCombo);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.signingTable[this.identityCombo]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(0));
            // Container child signingTable.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("_Identity:");
            this.label4.UseUnderline = true;
            this.signingTable.Add(this.label4);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.signingTable[this.label4]));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child signingTable.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("_Provisioning profile:");
            this.label6.UseUnderline = true;
            this.signingTable.Add(this.label6);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.signingTable[this.label6]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child signingTable.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Custom _entitlements:");
            this.label7.UseUnderline = true;
            this.signingTable.Add(this.label7);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.signingTable[this.label7]));
            w8.TopAttach = ((uint)(2));
            w8.BottomAttach = ((uint)(3));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child signingTable.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Custom _resource rules:");
            this.label8.UseUnderline = true;
            this.signingTable.Add(this.label8);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.signingTable[this.label8]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child signingTable.Gtk.Table+TableChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.Xalign = 0F;
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("_Additional arguments:");
            this.label9.UseUnderline = true;
            this.signingTable.Add(this.label9);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.signingTable[this.label9]));
            w10.TopAttach = ((uint)(4));
            w10.BottomAttach = ((uint)(5));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child signingTable.Gtk.Table+TableChild
            this.provisioningCombo = new Gtk.ComboBox();
            this.provisioningCombo.Name = "provisioningCombo";
            this.signingTable.Add(this.provisioningCombo);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.signingTable[this.provisioningCombo]));
            w11.TopAttach = ((uint)(1));
            w11.BottomAttach = ((uint)(2));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.YOptions = ((Gtk.AttachOptions)(0));
            // Container child signingTable.Gtk.Table+TableChild
            this.resourceRulesEntry = new MonoDevelop.Projects.Gui.ProjectFileEntry();
            this.resourceRulesEntry.Name = "resourceRulesEntry";
            this.resourceRulesEntry.EntryIsEditable = false;
            this.signingTable.Add(this.resourceRulesEntry);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.signingTable[this.resourceRulesEntry]));
            w12.TopAttach = ((uint)(3));
            w12.BottomAttach = ((uint)(4));
            w12.LeftAttach = ((uint)(1));
            w12.RightAttach = ((uint)(2));
            w12.YOptions = ((Gtk.AttachOptions)(0));
            this.alignment3.Add(this.signingTable);
            this.vbox3.Add(this.alignment3);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox3[this.alignment3]));
            w14.Position = 1;
            w14.Expand = false;
            w14.Fill = false;
            this.alignment2.Add(this.vbox3);
            this.vbox1.Add(this.alignment2);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox1[this.alignment2]));
            w16.Position = 1;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.label4.MnemonicWidget = this.identityCombo;
            this.label6.MnemonicWidget = this.provisioningCombo;
            this.label7.MnemonicWidget = this.entitlementsEntry;
            this.label8.MnemonicWidget = this.resourceRulesEntry;
            this.Hide();
        }
    }
}
