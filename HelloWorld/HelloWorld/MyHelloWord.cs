using System;
using System.Collections.Generic;
using System.Text;
using Urho;
using Urho.Gui;
using Xamarin.Forms;

namespace HelloWorld
{
    public class MyHelloWord : Urho.Application
    {
       
        public MyHelloWord(ApplicationOptions options=null) : base(options)
        {
            
        }

        protected override void Start()
        {
            base.Start();
            CreateText();
        }
        private void CreateText()
        {

            //  با ابزار های فرم کار نمی کند
            //var label = new Label()
            //{

            //    Text = "سلام",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment =TextAlignment.Center
            //};

            var text = new Text()
            {
                //فعلا به غیر از فونتی که خودشان ساختن کار نمی کند
                //Value = "سلام به همه این اولین برنامه من است با نام دنیازی من",
                Value="Hello World",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize=40,
                
                
               
            };

            text.SetColor(Urho.Color.Cyan);
            text.SetFont(font: ResourceCache.GetFont("Fonts/Anonymous Pro.ttf"),size: 40);

            //text.SetFont(font: ResourceCache.GetFont("Fonts/Yekan.ttf"), size: 40);

            //add to UI Root

            //با ابزار های دیگر نیز کار نمی کند
            //UI.Root.AddChild(text);
            UI.Root.AddChild(text);

          
        }
    }
}
