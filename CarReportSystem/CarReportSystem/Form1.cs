using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        // 終了ボタン
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit(); // アプリケーション終了
        }

        // 画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }    

        }

        // 画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        // 追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            
            listCarReport.Add(carReport);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        // 選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        // コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        // コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            } 
            // 選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            // 取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Author;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
           
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
           
        }

        private void btUpdate_Click(object sender, EventArgs e) {

            if (carReportDataGridView.CurrentRow == null) {
                return;
            }

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value; // 日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text; // 記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup(); // メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text; // 車種
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text; // レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image); // 画像

            // データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202114DataSet);
#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
#endif
        }

        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202114DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202114DataSet.CarReport);

#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        // 逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        //dgvRegistData.DataSource = null;
                        //dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

                // 読み込んだデータを各コンボボックスに登録する
                foreach (var item in listCarReport) {
                    setCbAuthor(item.Author);
                    setCbCarName(item.CarName);
                }

                // データグリッドビューから取得
                // for (int i = 0; i < dgvRegistData.RowCount; i++) {
                //     setCbAuthor(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                //     setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                // }
            }
#endif

        }

        private void fmMain_Load(object sender, EventArgs e) {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車種";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].HeaderText = "画像";
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) {
                return;
            }

            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value; // 日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString(); // 記録者
                setMakerRadioButton(
                    (CarReport.MakerGroup)
                        Enum.Parse(typeof(CarReport.MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString())
                ); // メーカー
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString(); // 車種
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString(); // レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value); // 画像
            }
            catch (Exception) {
                pbPicture.Image = null;
            }        
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }
    }
}
 