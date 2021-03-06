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
            // dgvRegistData.DataSource = listCarReport;
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
            setMakerRadioButton(selectedCar);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;

        }

        private void setMakerRadioButton(CarReport selectedCar) {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Text.Equals(selectedCar.Maker.ToString())) {
                    ((RadioButton)rb).Checked = true;
                }
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            // listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            // listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value, cbAuthor.Text, selectedGroup(), 
            //                                                     cbCarName.Text, tbReport.Text, pbPicture.Image);
            // dgvRegistData.Refresh(); // コントロールの強制再描画
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            if (true) {

            }

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value; // 日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text; // 記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup(); // メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text; // 車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text; // レポート

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
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
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
            // dgvRegistData.Columns[5].Visible = false;
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202114DataSet);

        }

        //private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
        //    this.carReportTableAdapter.deleteRow(carReportDataGridView.CurrentRow.Cells[0].Value,
        //                                         carReportDataGridView.CurrentRow.Cells[1].Value,
        //                                         carReportDataGridView.CurrentRow.Cells[2].Value,
        //                                         carReportDataGridView.CurrentRow.Cells[3].Value,
        //                                         carReportDataGridView.CurrentRow.Cells[4].Value,
        //                                         carReportDataGridView.CurrentRow.Cells[5].Value
        //                                         );

        //    //carReportDataGridView.CurrentRow.Cells[1].Value
        //    //carReportDataGridView.CurrentRow.Cells[2].Value
        //    //carReportDataGridView.CurrentRow.Cells[3].Value
        //    //carReportDataGridView.CurrentRow.Cells[4].Value
        //    //carReportDataGridView.CurrentRow.Cells[5].Value
        //}
    }
}
 