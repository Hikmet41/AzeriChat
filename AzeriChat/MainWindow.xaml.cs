using System;
using System.Collections.Generic;
using System.Windows;


namespace AzeriChat
{
    public partial class MainWindow : Window
    {

        public List<Message> messages { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            messages = new()
            {
                new Message {Message_ = "Salam aleykum",Date="00:00"},
                new Message {Message_ = "Aleykum Salam",Date="00:10"},
                new Message {Message_ = "niye gec cavab verirsen hormetsiz?",Date="00:11"},
                new Message {Message_ = "Isim var idide nolubee",Date="00:11"},
                new Message {Message_ = "Bu vaxti ne is ee qiznan danisiram demir",Date="00:12"},
                new Message {Message_ = "Ala yox senol isim var idi",Date="00:13"},
                new Message {Message_ = "Yeri gede senne adam olan dol",Date="00:25"},
            };
            DataContext = this;
        }
    }
}
