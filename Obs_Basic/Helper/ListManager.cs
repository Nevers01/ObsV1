using System;
using System.Windows.Forms;
using DbHelper;

namespace Obs_Basic.Helper
{
    public class ListManager
    {
        private readonly ListService _listService;

        public ListManager()
        {
            _listService = new ListService();
        }

        public void FillUserList(ListView listView)
        {
            var users = _listService.GetUserList();

            if (users.Count == 0)
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
                return;
            }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("İsim", 100);
            listView.Columns.Add("Soyisim", 100);
            listView.Columns.Add("Kullanıcı Adı", 100);
            listView.Columns.Add("Yetki", 100);
            listView.Columns.Add("Admin mi?", 80);

            foreach (var user in users)
            {
                var item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Surname);
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Role);
                item.SubItems.Add(user.IsAdmin ? "Evet" : "Hayır");

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        public void FillDiscList(ListView listView)
        {
            var discList = _listService.GetDiscList();

            if (discList.Count == 0)
            {
                MessageBox.Show("Devamsızlık kaydı bulunamadı.");
                return;
            }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Tarih", 100);
            listView.Columns.Add("Durum", 100);
            listView.Columns.Add("Öğrenci", 150);

            foreach (var disc in discList)
            {
                var item = new ListViewItem(disc.Id.ToString());
                item.SubItems.Add(disc.Date);
                item.SubItems.Add(disc.Status);
                item.SubItems.Add(disc.StudentName);

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        public void FillAnnoList(ListView listView)
        {
            var announcementList = _listService.GetAnnoList();

            if (announcementList.Count == 0)
            {
                MessageBox.Show("Duyuru bulunamadı.");
                return;
            }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Başlık", 150);
            listView.Columns.Add("İçerik", 300);
            listView.Columns.Add("Tipi", 20);
            listView.Columns.Add("Ders", 50);
            listView.Columns.Add("Tarih", 100);

            foreach (var ann in announcementList)
            {
                var item = new ListViewItem(ann.Id.ToString());
                item.SubItems.Add(ann.Title);
                item.SubItems.Add(ann.Content);
                item.SubItems.Add(ann.AnnoType);
                item.SubItems.Add(ann.AnnoEdu ?? "Ders Yok");
                item.SubItems.Add(ann.CreatedAt);

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        public void FillUserDiscList(ListView listView)
        {
            var discList = _listService.GetUserDiscList();

            if (discList.Count == 0)
            {
                MessageBox.Show("Devamsızlık kaydı bulunamadı.");
                return;
            }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Tarih", 100);
            listView.Columns.Add("Durum", 100);

            foreach (var disc in discList)
            {
                var item = new ListViewItem(disc.Id.ToString());
                item.SubItems.Add(disc.Date);
                item.SubItems.Add(disc.Status);

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        public void FillNoteList(ListView listView)
        {
            var NoteList = _listService.GetAllNotes();

            if (NoteList.Count == 0)
            {
                MessageBox.Show("Not kaydı bulunamadı.");
                return;
            }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Öğrenci ID", 80);
            listView.Columns.Add("Ders Kodu", 100);
            listView.Columns.Add("Not Değeri", 100);

            foreach (var note in NoteList)
            {
                var item = new ListViewItem(note.Id.ToString());
                item.SubItems.Add(note.StudentId.ToString());
                item.SubItems.Add(note.DersKodu);
                item.SubItems.Add(note.NotDegeri.ToString());

                listView.Items.Add(item);
            }

            listView.Refresh();
        }
    }
}