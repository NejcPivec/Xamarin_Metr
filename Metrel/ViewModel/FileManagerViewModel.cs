using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Metrel
{
    public class FileManagerViewModel
    {
        #region Fields

        private ObservableCollection<FileManager> imageNodeInfo;

        #endregion

        #region Constructor

        public FileManagerViewModel()
        {
            GenerateSource();
        }

        #endregion

        #region Properties

        public ObservableCollection<FileManager> ImageNodeInfo
        {
            get { return imageNodeInfo; }
            set { this.imageNodeInfo = value; }
        }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            var nodeImageInfo = new ObservableCollection<FileManager>();
            Assembly assembly = typeof(TreePage).GetTypeInfo().Assembly;

            var ground = new FileManager() { ItemName = "Ground Floor", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_folder.png", assembly) };
            var floor_1 = new FileManager() { ItemName = "Floor 1", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_folder.png", assembly) };
            var floor_2 = new FileManager() { ItemName = "Floor 2", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_folder.png", assembly) };
            var floor_3 = new FileManager() { ItemName = "Floor 3", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_folder.png", assembly) };

            var room_1 = new FileManager() { ItemName = "Room 1", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_word.png", assembly) };
            var room_2 = new FileManager() { ItemName = "Room 2", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_ppt.png", assembly) };
            var room_3 = new FileManager() { ItemName = "Room 3", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_word.png", assembly) };
            var room_4 = new FileManager() { ItemName = "Room 4", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_pdf.png", assembly) };
            var room_5 = new FileManager() { ItemName = "Room 5", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_pdf.png", assembly) };

            var light_1 = new FileManager() { ItemName = "Light", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_exe.png", assembly) };
            var light_2 = new FileManager() { ItemName = "Light", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_zip.png", assembly) };
            var light_3 = new FileManager() { ItemName = "Light", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_zip.png", assembly) };
            var light_4 = new FileManager() { ItemName = "Light", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_pdf.png", assembly) };

            var dryer = new FileManager() { ItemName = "Hair Dryer", ImageIcon = ImageSource.FromResource("Metrel.Icons.treeview_mp3.png", assembly) };


            ground.SubFiles = new ObservableCollection<FileManager>
            {
                 room_1
            };


            floor_1.SubFiles = new ObservableCollection<FileManager>
            {
                room_2
            };

            floor_2.SubFiles = new ObservableCollection<FileManager>
            {
                 room_3,
            };

            floor_3.SubFiles = new ObservableCollection<FileManager>
            {
                room_4,
                room_5
            };

            room_2.SubFiles = new ObservableCollection<FileManager>
            {
                light_1,
                light_2
            };

            room_3.SubFiles = new ObservableCollection<FileManager>
            {
                light_3,
                light_4,
                dryer
            };



            nodeImageInfo.Add(ground);
            nodeImageInfo.Add(floor_1);
            nodeImageInfo.Add(floor_2);
            nodeImageInfo.Add(floor_3);
            imageNodeInfo = nodeImageInfo;
        }

        #endregion

    }
}