using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace WpfApp1.Model
{
    class ListTitle : ObservableCollection<Title>
    {
        public ListTitle()
        {
            DbSet<Title> titles = PageEmploye.DataEntitiesEmploye.Titles;

            var queryTitle = from title in titles select title;
            foreach (Title title in queryTitle)
            {
                this.Add(title);
            }
        }
    }
} 
