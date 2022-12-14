namespace DXApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnStore = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.proDuctList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ImportInput = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ExportInput = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnDetail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Other = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Exit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.PrintProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 55);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1315, 787);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnStore,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.Other});
            this.accordionControl1.Location = new System.Drawing.Point(0, 55);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 787);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnStore
            // 
            this.mnStore.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.proDuctList});
            this.mnStore.Expanded = true;
            this.mnStore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnStore.ImageOptions.SvgImage")));
            this.mnStore.Name = "mnStore";
            this.mnStore.Text = "Store";
            // 
            // proDuctList
            // 
            this.proDuctList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("proDuctList.ImageOptions.Image")));
            this.proDuctList.Name = "proDuctList";
            this.proDuctList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.proDuctList.Text = "Product List";
            this.proDuctList.Click += new System.EventHandler(this.proDuctList_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ImportInput,
            this.ExportInput});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Input";
            // 
            // ImportInput
            // 
            this.ImportInput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ImportInput.ImageOptions.Image")));
            this.ImportInput.Name = "ImportInput";
            this.ImportInput.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ImportInput.Text = "Import Input";
            this.ImportInput.Click += new System.EventHandler(this.ImportInput_Click_1);
            // 
            // ExportInput
            // 
            this.ExportInput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExportInput.ImageOptions.Image")));
            this.ExportInput.Name = "ExportInput";
            this.ExportInput.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ExportInput.Text = "Export Input";
            this.ExportInput.Click += new System.EventHandler(this.ImportInput_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnDetail});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Receipt";
            // 
            // mnDetail
            // 
            this.mnDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnDetail.ImageOptions.Image")));
            this.mnDetail.Name = "mnDetail";
            this.mnDetail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnDetail.Text = "Detail";
            this.mnDetail.Click += new System.EventHandler(this.mnDetail_Click);
            // 
            // Other
            // 
            this.Other.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Exit});
            this.Other.Expanded = true;
            this.Other.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Other.ImageOptions.SvgImage")));
            this.Other.Name = "Other";
            this.Other.Text = "Others";
            // 
            // Exit
            // 
            this.Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit.ImageOptions.Image")));
            this.Exit.Name = "Exit";
            this.Exit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1575, 55);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // PrintProduct
            // 
            this.PrintProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PrintProduct.ImageOptions.Image")));
            this.PrintProduct.Name = "PrintProduct";
            this.PrintProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PrintProduct.Text = "Print";
            this.PrintProduct.Click += new System.EventHandler(this.PrintProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 842);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnStore;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnDetail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Other;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Exit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ExportInput;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ImportInput;
        private DevExpress.XtraBars.Navigation.AccordionControlElement proDuctList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PrintProduct;
    }
}

