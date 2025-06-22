using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DbHelper;
using DbHelper.DTOS;
using DbHelper.Services;
using Obs_Basic.Helper;

namespace Obs_Basic
{
    public partial class AdminForm : Form
    {
        private readonly ListManager _listManager = new ListManager();
        private readonly NoteService _noteService = new NoteService();

        public AdminForm()
        {
            InitializeComponent();
            RefreshAllLists();
            LoadComboBoxData();
            RefreshNoteList();
        }

        private void RefreshAllLists()
        {
            _listManager.FillUserList(mainUserList);
            _listManager.FillUserList(UserList);

            var discLists = new[] { DiscList, DiscListAdd, DiscListDelete, DiscListUpdate };
            foreach (var disc in discLists)
                _listManager.FillUserList(disc);

            var annoLists = new[] { AnnoList, AnnoUpdateList, AnnoRemoveList, AnnoAddList };
            foreach (var list in annoLists)
                _listManager.FillAnnoList(list);

            var noteLists = new[] { lvNotlar, lvNotlarDel, lvNotlarUp };
            foreach (var list in noteLists)
                _listManager.FillNoteList(list);
        }

        private void LoadComboBoxData()
        {
            var authorized = LookupService.GetAuthorities();
            var statusList = LookupService.GetStatuses();
            var education = LookupService.GetEducations();
            var user = LookupService.GetUsers();

            userroleadd_cmb.Items.AddRange(authorized.ToArray());
            userroleupdate_cmb.Items.AddRange(authorized.ToArray());
            discstatusadd_cmb.Items.AddRange(statusList.ToArray());
            Annoedu_cmb.Items.AddRange(education.ToArray());
            cmbDers.Items.AddRange(education.ToArray());
            cmbOgrenci.Items.AddRange(user.ToArray());

            Annotype_cmb.Items.Add("Ders Bazlı");
            Annotype_cmb.Items.Add("Genel");
            Annotype_cmb.Items.Add("Etkinlik");
        }

        private void useradd_btn_Click(object sender, EventArgs e)
        {
            var result = new Create().User_Add(name_add.Text, surname_add.Text, password_add.Text, tcknadd_txt.Text, userroleadd_cmb.Text);
            UiNotifier.ShowResult(result, () =>
            {
                _listManager.FillUserList(mainUserList);
                _listManager.FillUserList(UserList);
            });
        }

        private void userremove_btn_Click(object sender, EventArgs e)
        {
            if (!UiNotifier.Confirm("Bu kullanıcıyı silmek istiyor musunuz?")) return;

            var dto = new UserDTO { Name = name_remove.Text, Surname = surname_remove.Text };
            var result = new Delete().User_Delete(dto);
            UiNotifier.ShowResult(result, () =>
            {
                _listManager.FillUserList(mainUserList);
                _listManager.FillUserList(UserList);
            });
        }

        private void UserSearch_btn_Click(object sender, EventArgs e)
        {
            var result = new Update().User_Search(searchname_txt.Text, searchsurname_txt.Text);

            if (result.IsSuccess && result.Data != null)
            {
                var user = result.Data;
                updateid_txt.Text = user.Id.ToString();
                updatename_txt.Text = user.Name;
                updatesurname_txt.Text = user.Surname;
                UiNotifier.ShowSuccess($"Kullanıcı bulundu: {user.Name} {user.Surname}");
            }
            else
            {
                UiNotifier.ShowError("Kullanıcı bulunamadı.");
            }
        }

        private void UserUpdate_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(updateid_txt.Text, out int userId))
            {
                UiNotifier.ShowError("Geçerli bir kullanıcı ID girin.");
                return;
            }

            var userDto = new UserDTO
            {
                Id = userId,
                Name = updatename_txt.Text,
                Surname = updatesurname_txt.Text,
                TCKN = tcnkUpdate_txt.Text,
                Role = userroleupdate_cmb.Text
            };

            var result = new Update().User_Update(userDto);
            UiNotifier.ShowResult(result, () =>
            {
                _listManager.FillUserList(mainUserList);
                _listManager.FillUserList(UserList);
            });
        }

        private void AdmLogout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void DiscAdd_btn_Click(object sender, EventArgs e)
        {
            var isRaporlu = discstatusadd_cmb.SelectedItem?.ToString() == "Raporlu";
            var result = new Create().Disc_Add(discdateadd_dt.Value, isRaporlu, discnamesearch_txt.Text, discsurnamesearch_txt.Text);
            UiNotifier.ShowResult(result, RefsreshDiscList);
        }

        private void AnnoUpdate_btn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedAnnoId(AnnoUpdateList, out int id)) return;

            var dto = new AnnoDTO
            {
                Id = id,
                Title = AnnoTitleUpdate_txt.Text,
                Content = AnnoContentUpdate_txt.Text
            };

            var result = new Update().Anno_Update(dto);
            UiNotifier.ShowResult(result, RefreshAnnoLists);
        }

        private void AnnoRemove_btn_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedAnnoId(AnnoRemoveList, out int id)) return;

            if (!UiNotifier.Confirm("Bu duyuruyu silmek istediğinize emin misiniz?")) return;

            var result = new Delete().Anno_Delete(id);
            UiNotifier.ShowResult(result, RefreshAnnoLists);
        }

        private void AnnoAdd_btn_Click(object sender, EventArgs e)
        {
            if (Annotype_cmb.Text == "Ders Bazlı")
            {
                var dto = new AnnoDTO { Title = AnnoTitleAdd_txt.Text, Content = AnnoContentAdd_txt.Text, AnnoType = Annotype_cmb.Text, AnnoEdu = Annoedu_cmb.Text };
                var result = new Create().Anno_Add(dto);
                UiNotifier.ShowResult(result, RefreshAnnoLists);
            }
            else
            {
                var dto = new AnnoDTO { Title = AnnoTitleAdd_txt.Text, Content = AnnoContentAdd_txt.Text, AnnoType = Annotype_cmb.Text };
                var result = new Create().Anno_Add(dto);
                UiNotifier.ShowResult(result, RefreshAnnoLists);
            }
        }

        private bool TryGetSelectedAnnoId(ListView list, out int id)
        {
            id = 0;
            if (list.SelectedItems.Count == 0)
            {
                UiNotifier.ShowError("Lütfen bir duyuru seçin.");
                return false;
            }

            return int.TryParse(list.SelectedItems[0].SubItems[0].Text, out id);
        }

        private void RefreshAnnoLists()
        {
            var annoLists = new[] { AnnoList, AnnoUpdateList, AnnoRemoveList, AnnoAddList };
            foreach (var list in annoLists)
                _listManager.FillAnnoList(list);
        }

        private void RefsreshDiscList()
        {
            var discLists = new[] { DiscList, DiscListAdd, DiscListDelete, DiscListUpdate };
            foreach (var disc in discLists)
                _listManager.FillUserList(disc);
        }

        private void RefreshNoteList()
        {
            var noteLists = new[] { lvNotlar, lvNotlarDel, lvNotlarUp };
            foreach (var list in noteLists)
                _listManager.FillNoteList(list);
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            var dto = new NoteDTO
            {
                StudentId = Convert.ToInt32(cmbOgrenci.SelectedValue),
                DersKodu = cmbDers.SelectedValue.ToString(),
                NotDegeri = Convert.ToDecimal(txtNotDegeri.Text),
                Tarih = dtTarih.Value.Date
            };

            var result = _noteService.AddNote(dto);
            MessageBox.Show(result.Message);
            RefreshNoteList();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            if (lvNotlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            int notId = Convert.ToInt32(lvNotlarUp.SelectedItems[0].Text);

            var dto = new NoteDTO
            {
                Id = notId,
                StudentId = Convert.ToInt32(cmbOgrenci.SelectedValue),
                DersKodu = cmbDers.SelectedValue.ToString(),
                NotDegeri = Convert.ToDecimal(txtNotDegeri.Text),
                Tarih = dtTarih.Value.Date
            };

            var result = _noteService.UpdateNote(dto);
            MessageBox.Show(result.Message);
            RefreshNoteList();
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            if (lvNotlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seçin.");
                return;
            }

            int notId = Convert.ToInt32(lvNotlarDel.SelectedItems[0].Text);

            var result = _noteService.DeleteNote(notId);
            MessageBox.Show(result.Message);
            RefreshNoteList();
        }
    }
}