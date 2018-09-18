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
            var label = new Label()
            {

                Text = "سلام",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment =TextAlignment.Center
            };

            var text = new Text()
            {
                //Value = "سلام به همه این اولین برنامه من است با نام دنیازی من",
                Value="سلام",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize=40,
                
                
               
            };

            text.SetColor(Urho.Color.Cyan);
            text.SetFont(font: ResourceCache.GetFont("Fonts/Anonymous Pro.ttf"),size: 40);
            //text.SetFont(font: ResourceCache.GetFont("Fonts/Yekan.ttf"), size: 40);

            //add to UI Root

            //UI.Root.AddChild(text);
            UI.Root.AddChild(text);

          
        }
    }
}
