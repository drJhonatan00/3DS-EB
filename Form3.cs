using Microsoft.VisualBasic; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp10
{
    public partial class Form3 : Form
    {
        string cam = @"WindowsFormsApp10.config";
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);
            string nomeArquivo = txtNomeArquivo.Text.Trim();

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                string datas = File.ReadAllText(cam);
                if (datas == "EN")
                {
                    MessageBox.Show("Please enter the name of the .3DS file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "ES")
                {
                    MessageBox.Show("Por favor, introduzca el nombre del archivo .3DS!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "KO")
                {
                    MessageBox.Show(".3DS 파일의 이름을 입력하세요!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "JA")
                {
                    MessageBox.Show(".3DSファイルの名前を入力してください！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "AL")
                {
                    MessageBox.Show("Bitte geben Sie den Namen der .3DS-Datei ein!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "IT")
                {
                    MessageBox.Show("Inserisci il nome del file .3DS!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "FR")
                {
                    MessageBox.Show("Veuillez saisir le nom du fichier .3DS !", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "CH")
                {
                    MessageBox.Show("请输入.3DS文件的名称！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "PT")
                {
                    MessageBox.Show("Por favor, digite o nome do arquivo .3DS!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Please enter the name of the .3DS file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SetUIState(true);
                return;
            }

            string datalog = File.ReadAllText(cam);
            if (datalog == "EN")
            {
                lblStatus.Text = "Starting .3DS extraction";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Iniciando la extracción del archivo .3DS";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = ".3DS 파일 추출 시작";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = ".3DSファイルの抽出を開始します";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = ".3DS-Extraktion wird gestartet";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Avvio dell'estrazione del file .3DS";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Démarrage de l'extraction .3DS";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "开始提取.3DS文件";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Iniciando extração do .3DS";

            }
            else
            {
                lblStatus.Text = "Starting .3DS extraction";
            }

            string argsStage1 = $"-xvt01267f cci DecryptedPartition0.bin DecryptedPartition1.bin DecryptedPartition2.bin DecryptedPartition6.bin DecryptedPartition7.bin {nomeArquivo}.3ds --header HeaderNCSD.bin";
            bool sucesso1 = await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

            if (sucesso1)
            {
                

                string argsStage2 = "-xvtf cxi DecryptedPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
                await ExecutarFerramentaAsync("3dstool.exe", argsStage2);

                DeletarSeExistir("DecryptedPartition0.bin");
                DeletarSeExistir("DecryptedPartition1.bin");
                DeletarSeExistir("DecryptedPartition2.bin");
                DeletarSeExistir("DecryptedPartition6.bin");
                DeletarSeExistir("DecryptedPartition7.bin");

                lblStatus.Text = "ExeFS/RomFS extraction...";
                await ExecutarFerramentaAsync("3dstool.exe", "-xvtfu exefs DecryptedExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");
                await ExecutarFerramentaAsync("3dstool.exe", "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS");

                OrganizarArquivosBanner();

                
                MessageBox.Show("Sucess!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblStatus.Text = "Ocorreu uma falha na extração.";
                string datal = File.ReadAllText(cam);
                if (datal == "EN")
                {
                    MessageBox.Show("Unable to process the .3DS file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "ES")
                {
                    MessageBox.Show("No se pudo procesar el archivo .3DS. Compruebe si el archivo está dañado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "KO")
                {
                    MessageBox.Show(".3DS 파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "JA")
                {
                    MessageBox.Show(".3DSファイルを処理できませんでした。ファイルが破損していないか確認してください。", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "AL")
                {
                    MessageBox.Show("Die .3DS-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "IT")
                {
                    MessageBox.Show("Impossibile elaborare il file .3DS. Verificare se il file è danneggiato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "FR")
                {
                    MessageBox.Show("Le fichier .3DS n'a pas pu être traité. Veuillez vérifier s'il est corrompu.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "CH")
                {
                    MessageBox.Show("无法处理 .3DS 文件。请检查文件是否已损坏。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "PT")
                {
                    MessageBox.Show("Não foi possível processar o arquivo .3DS. Verifique se o arquivo não está corrompido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Unable to process the .3DS file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            SetUIState(true);
        }

        private async void btnRebuild3DS_Click(object sender, EventArgs e)
        {
            string a = File.ReadAllText(cam);
            txtLog.Clear();

            string outputFilename = Interaction.InputBox(
                "Write the .3DS file name (without extension):",
                "Rebuild .3DS",
                ""
                );

            if (string.IsNullOrWhiteSpace(outputFilename)) return;

            SetUIState(false);
            lblStatus.Text = "";

            try
            {
                bool sucesso = await ExecuteRebuild3DSPipelineAsync(outputFilename);

                if (sucesso)
                {
                    lblStatus.Text = "";
                    string data = File.ReadAllText(cam);
                    if (data == "EN")
                    {
                        MessageBox.Show($"Process Completed\n{outputFilename}_Edited.3ds", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "ES")
                    {
                        MessageBox.Show($"Processo Completado\n{outputFilename}_Edited.3ds", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "KO")
                    {
                        MessageBox.Show($"프로세스 완료됨\n{outputFilename}_Edited.3ds", "완전한", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "JA")
                    {
                        MessageBox.Show($"処理が完了しました\n{outputFilename}_Edited.3ds", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "AL")
                    {
                        MessageBox.Show($"Prozess abgeschlossen\n{outputFilename}_Edited.3ds", "Vollendet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "IT")
                    {
                        MessageBox.Show($"Processo Completato\n{outputFilename}_Edited.3ds", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "FR")
                    {
                        MessageBox.Show($"Processus terminé\n{outputFilename}_Edited.3ds", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "CH")
                    {
                        MessageBox.Show($"流程已完成\n{outputFilename}_Edited.3ds", "完全的", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "PT")
                    {
                        MessageBox.Show($"Processo finalizado!\n{outputFilename}_Edited.3ds", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"Process Completed.\n{outputFilename}_Edited.3ds", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    lblStatus.Text = "Error";
                    MessageBox.Show("Error: 0x0132sds2e0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUIState(true);
            }
        }

        private async Task<bool> ExecuteRebuild3DSPipelineAsync(string outputName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            SafeRename(Path.Combine(baseDir, @"ExtractedBanner\banner.cgfx"), "banner0.bcmdl");
            await ExecutarFerramentaAsync("3dstool.exe", "-cv -t banner -f banner.bin --banner-dir ExtractedBanner\\");
            SafeRename(Path.Combine(baseDir, @"ExtractedBanner\banner0.bcmdl"), "banner.cgfx");

            string bannerBin = Path.Combine(baseDir, "banner.bin");
            string targetBanner = Path.Combine(baseDir, @"ExtractedExeFS\banner.bin");
            if (File.Exists(bannerBin))
            {
                File.Copy(bannerBin, targetBanner, overwrite: true);
                File.Delete(bannerBin);
            }

            SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\banner.bin"), "banner.bnr");
            SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\icon.bin"), "icon.icn");

            await ExecutarFerramentaAsync("3dstool.exe", "-cvtfz exefs CustomExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");
            SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\banner.bnr"), "banner.bin");
            SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\icon.icn"), "icon.bin");

            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomRomFS.bin --romfs-dir ExtractedRomFS");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomManual.bin --romfs-dir ExtractedManual");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomDownloadPlay.bin --romfs-dir ExtractedDownloadPlay");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomN3DSUpdate.bin --romfs-dir ExtractedN3DSUpdate");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomO3DSUpdate.bin --romfs-dir ExtractedO3DSUpdate");

            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cxi CustomPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs CustomExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs CustomRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cfa CustomPartition1.bin --header HeaderNCCH1.bin --romfs CustomManual.bin --romfs-auto-key");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cfa CustomPartition2.bin --header HeaderNCCH2.bin --romfs CustomDownloadPlay.bin --romfs-auto-key");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cfa CustomPartition6.bin --header HeaderNCCH6.bin --romfs CustomN3DSUpdate.bin --romfs-auto-key");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cfa CustomPartition7.bin --header HeaderNCCH7.bin --romfs CustomO3DSUpdate.bin --romfs-auto-key");

            var customBins = Directory.GetFiles(baseDir, "Custom*.bin");
            foreach (var bin in customBins)
            {
                FileInfo fi = new FileInfo(bin);
                if (fi.Length <= 20000)
                {
                    fi.Delete();
                }
            }
            bool resultadoFinal = await ExecutarFerramentaAsync("3dstool.exe", $"-cvt01267f cci CustomPartition0.bin CustomPartition1.bin CustomPartition2.bin CustomPartition6.bin CustomPartition7.bin {outputName}_Edited.3ds --header HeaderNCSD.bin");

            string[] tempBins = { "CustomPartition0.bin", "CustomPartition1.bin", "CustomPartition2.bin", "CustomPartition6.bin", "CustomPartition7.bin" };
            foreach (var file in tempBins)
            {
                DeletarSeExistir(Path.Combine(baseDir, file));
            }

            return resultadoFinal;
        }

        private Task<bool> ExecutarFerramentaAsync(string executavel, string argumentos)
        {
            return Task.Run(() =>
            {
                try
                {
                    string caminhoApp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppFiles", executavel);

                    if (!File.Exists(caminhoApp))
                    {
                        Invoke(new Action(() => txtLog.AppendText($"[ERROR]: The file {executavel} wasn't found on AppFiles folder!\r\n")));
                        return false;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = caminhoApp,
                        Arguments = argumentos,
                        WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process processo = new Process { StartInfo = psi })
                    {
                        processo.OutputDataReceived += (s, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                                Invoke(new Action(() => txtLog.AppendText(e.Data + Environment.NewLine)));
                        };

                        processo.ErrorDataReceived += (s, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                                Invoke(new Action(() => txtLog.AppendText($"[ERROR]: {e.Data}\r\n")));
                        };

                        processo.Start();
                        processo.BeginOutputReadLine();
                        processo.BeginErrorReadLine();
                        processo.WaitForExit();

                        return processo.ExitCode == 0;
                    }
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => txtLog.AppendText($"[EXCEPTION]: {ex.Message}\r\n")));
                    return false;
                }
            });
        }

        private void SetUIState(bool enabled)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetUIState(enabled)));
                return;
            }

            button1.Enabled = enabled;
            btnRebuild3DS.Enabled = enabled;
            btnExtractCIA.Enabled = enabled;
            btnRebuildCIA.Enabled = enabled;
        }

        private void DeletarSeExistir(string caminho)
        {
            if (File.Exists(caminho)) File.Delete(caminho);
        }

        private void SafeRename(string sourcePath, string newName)
        {
            if (File.Exists(sourcePath))
            {
                string directory = Path.GetDirectoryName(sourcePath);
                string destination = Path.Combine(directory, newName);
                if (File.Exists(destination)) File.Delete(destination);
                File.Move(sourcePath, destination);
            }
        }

        private void OrganizarArquivosBanner()
        {
            try
            {
                string pathExeFS = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractedExeFS");
                string pathBanner = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExtractedBanner");

                if (File.Exists(Path.Combine(pathExeFS, "banner.bnr")))
                    File.Move(Path.Combine(pathExeFS, "banner.bnr"), Path.Combine(pathExeFS, "banner.bin"));

                if (File.Exists(Path.Combine(pathExeFS, "icon.icn")))
                    File.Move(Path.Combine(pathExeFS, "icon.icn"), Path.Combine(pathExeFS, "icon.bin"));

                if (File.Exists(Path.Combine(pathExeFS, "banner.bin")))
                    File.Copy(Path.Combine(pathExeFS, "banner.bin"), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "banner.bin"), true);

                ExecutarFerramentaAsync("3dstool.exe", "-xv -t banner -f banner.bin --banner-dir ExtractedBanner\\").Wait();

                DeletarSeExistir("banner.bin");

                if (File.Exists(Path.Combine(pathBanner, "banner0.bcmdl")))
                    File.Move(Path.Combine(pathBanner, "banner0.bcmdl"), Path.Combine(pathBanner, "banner.cgfx"));
            }
            catch { }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string alpha = File.ReadAllText(cam);
            txtLog.ReadOnly = true;
            
            if(alpha == "PT")
            {
                label3.Text = "Escolha uma Opção";
                button1.Text = "Extrair Arquivo .3DS";
                btnExtractCIA.Text = "Extrair Arquivo .CIA";
                btnRebuild3DS.Text = "Compilar Arquivo .3DS";
                btnRebuildCIA.Text = "Compilar Arquivo .CIA";
                btnMassExtract.Text = "Extrair Massivo";
                btnMassRebuild.Text = "Compilar Massivo";
                btnExtractBanner.Text = "Extrair Banner Descriptografado";
                btnRebuildBanner.Text = "Compilar Banner Descriptografado";
                btnExtractNCCH.Text = "Extrair Partição NCCH";
                btnExtractFilePartition.Text = "Extrair Partição de Arquivo";
                btnExtractCXI.Text = "Extrair Arquivo .CXI";
                label2.Text = "Relatório";
                label1.Text = "Digite o nome do arquivo (sem extensão)";
                lblStatus.Text = "Status";
                btnLang.Text = "Trocar Idioma";
            }
            else if (alpha == "EN")
            {
                label3.Text = "Choose an Option";
                button1.Text = "Extract .3DS File";
                btnExtractCIA.Text = "Extract .CIA File";
                btnRebuild3DS.Text = "Rebuild .3DS File";
                btnRebuildCIA.Text = "Rebuild .CIA File";
                btnMassExtract.Text = "Mass Extract";
                btnMassRebuild.Text = "Mass Rebuild";
                btnExtractBanner.Text = "Extract a Decrypted Banner";
                btnRebuildBanner.Text = "Rebuild a Decrypted Banner";
                btnExtractNCCH.Text = "Extract a NCCH Partition";
                btnExtractFilePartition.Text = "Extract File Partition";
                btnExtractCXI.Text = "Extract .CXI File";
                label2.Text = "Report";
                label1.Text = "Write the file name (Without Extension)";
                lblStatus.Text = "Status";
                btnLang.Text = "Change Language";
            }
            else if (alpha == "ES")
            {
                label3.Text = "Elige una Opción";
                button1.Text = "Extraer Archivo .3DS";
                btnExtractCIA.Text = "Extraer Archivo .CIA";
                btnRebuild3DS.Text = "Compilar Archivo .3DS";
                btnRebuildCIA.Text = "Compilar Archivo .CIA";
                btnMassExtract.Text = "Extracción Masiva";
                btnMassRebuild.Text = "Recopilación Masiva";
                btnExtractBanner.Text = "Extraer Banner Descrifado";
                btnRebuildBanner.Text = "Compilar Banner Descrifado";
                btnExtractNCCH.Text = "Extraer NCCH Partition";
                btnExtractFilePartition.Text = "Extraer Partición de Archivo";
                btnExtractCXI.Text = "Extraer Archivo .CXI";
                label2.Text = "Informe";
                label1.Text = "Escribe el nombre del archivo (Sin la Extensión)";
                lblStatus.Text = "Status";
                btnLang.Text = "Cambiar Idioma";
            }
            else if (alpha == "KO")
            {
                label3.Text = "아래 옵션 중 하나를 선택하세요";
                button1.Text = ".3DS 파일 추출";
                btnExtractCIA.Text = ".CIA 파일 추출";
                btnRebuild3DS.Text = ".3DS 파일 컴파일";
                btnRebuildCIA.Text = ".CIA 파일 컴파일";
                btnMassExtract.Text = "대규모 추출";
                btnMassRebuild.Text = "대규모 컴파일";
                btnExtractBanner.Text = "복호화된 배너 추출";
                btnRebuildBanner.Text = "컴파일된 복호화된 배너";
                btnExtractNCCH.Text = "NCCH 파일 파티션 추출";
                btnExtractFilePartition.Text = "추출 파일 파티션";
                btnExtractCXI.Text = ".CXI 파일 추출";
                label2.Text = "보고서";
                label1.Text = "파일 이름(확장자 제외)을 입력하세요";
                lblStatus.Text = "프로그램 상태";
                btnLang.Text = "언어 전환";
            }
            else if (alpha == "JA")
            {
                label3.Text = "以下の選択肢からお選びください。";
                button1.Text = ".3DSファイルを抽出";
                btnExtractCIA.Text = ".CIAファイルを抽出";
                btnRebuild3DS.Text = ".3DSファイルをコンパイルする";
                btnRebuildCIA.Text = ".CIAファイルをコンパイルする";
                btnMassExtract.Text = "大量ファイル抽出";
                btnMassRebuild.Text = "大量のファイルのコンパイル";
                btnExtractBanner.Text = "復号化されたバナーを抽出";
                btnRebuildBanner.Text = "復号化されたバナーをコンパイルする";
                btnExtractNCCH.Text = "NCCHファイルパーティションを抽出します";
                btnExtractFilePartition.Text = "ファイルパーティションの抽出";
                btnExtractCXI.Text = ".CXIファイルを抽出";
                label2.Text = "報告";
                label1.Text = "ファイル名（拡張子なし）を入力してください";
                lblStatus.Text = "プログラムステータス";
                btnLang.Text = "言語を変更する";
            }
            else if (alpha == "CH")
            {
                label3.Text = "请选择以下选项";
                button1.Text = "提取.3DS文件";
                btnExtractCIA.Text = "提取.CIA文件";
                btnRebuild3DS.Text = "编译 .3DS 文件";
                btnRebuildCIA.Text = "编译 .CIA 文件";
                btnMassExtract.Text = "大规模提取";
                btnMassRebuild.Text = "大型合集";
                btnExtractBanner.Text = "提取解密横幅";
                btnRebuildBanner.Text = "编译解密横幅";
                btnExtractNCCH.Text = "提取 NCCH 文件分区";
                btnExtractFilePartition.Text = "提取文件分区";
                btnExtractCXI.Text = "提取.CXI文件";
                label2.Text = "报告";
                label1.Text = "写出文件名（不含扩展名）";
                lblStatus.Text = "项目状态";
                btnLang.Text = "切换语言";
            }
            else if (alpha == "AL")
            {
                label3.Text = "Wählen Sie eine Option";
                button1.Text = ".3DS-Datei extrahieren";
                btnExtractCIA.Text = ".CIA-Datei extrahieren";
                btnRebuild3DS.Text = ".3DS-Datei kompilieren";
                btnRebuildCIA.Text = ".CIA-Datei kompilieren";
                btnMassExtract.Text = "Massenextraktion";
                btnMassRebuild.Text = "Massive Zusammenstellung";
                btnExtractBanner.Text = "Entschlüsseltes Banner extrahieren";
                btnRebuildBanner.Text = "Entschlüsseltes Banner kompilieren";
                btnExtractNCCH.Text = "NCCH-Dateipartition extrahieren";
                btnExtractFilePartition.Text = "Dateipartition extrahieren";
                btnExtractCXI.Text = ".CXI-Datei extrahieren";
                label2.Text = "Bericht";
                label1.Text = "Geben Sie den Dateinamen (ohne Dateiendung) ein.";
                lblStatus.Text = "Status";
                btnLang.Text = "Sprache Ändern";
            }
            else if (alpha == "FR")
            {
                label3.Text = "Choisissez une Option";
                button1.Text = "Extraire Fichier .3DS";
                btnExtractCIA.Text = "Extraire Fichier .CIA";
                btnRebuild3DS.Text = "Compiler Fichier .3DS";
                btnRebuildCIA.Text = "Compiler Fichier .CIA";
                btnMassExtract.Text = "Extracteur de Masse";
                btnMassRebuild.Text = "Reconstructeur de Masse";
                btnExtractBanner.Text = "Extraire une Bannière";
                btnRebuildBanner.Text = "Compiler une Bannière";
                btnExtractNCCH.Text = "Extraire une Partition NCCH";
                btnExtractFilePartition.Text = "Extraire les Données d'une Partition";
                btnExtractCXI.Text = "Extraire Fichier .CXI";
                label2.Text = "Rapport";
                label1.Text = "Indiquez le nom du fichier (Sans l'extension)";
                lblStatus.Text = "État du Programme";
                btnLang.Text = "Changer de Langue";
            }
            else if (alpha == "IT")
            {
                label3.Text = "Scegli un'opzione";
                button1.Text = "Estrai il file .3DS";
                btnExtractCIA.Text = "Estrai il file .CIA";
                btnRebuild3DS.Text = "Compila il file .3DS";
                btnRebuildCIA.Text = "Compila il file .CIA";
                btnMassExtract.Text = "Extrazione di Massa";
                btnMassRebuild.Text = "Raccolta di Massa";
                btnExtractBanner.Text = "Estratto del Banner Descrittografato";
                btnRebuildBanner.Text = "Compilare il Banner Descrittografato";
                btnExtractNCCH.Text = "Extrarre la Partizione NCCH";
                btnExtractFilePartition.Text = "Partizione File di Estrazione";
                btnExtractCXI.Text = "Estrai il file .CXI";
                label2.Text = "Rapporto";
                label1.Text = "Scrivi il nome del file (Senza estensione)";
                lblStatus.Text = "Stato";
                btnLang.Text = "Cambia Lingua";
            }
            else
            {
                label3.Text = "Choose an Option";
                button1.Text = "Extract .3DS File";
                btnExtractCIA.Text = "Extract .CIA File";
                btnRebuild3DS.Text = "Rebuild .3DS File";
                btnRebuildCIA.Text = "Rebuild .CIA File";
                btnMassExtract.Text = "Mass Extract";
                btnMassRebuild.Text = "Mass Rebuild";
                btnExtractBanner.Text = "Extract a Decrypted Banner";
                btnRebuildBanner.Text = "Rebuild a Decrypted Banner";
                btnExtractNCCH.Text = "Extract a NCCH Partition";
                btnExtractFilePartition.Text = "Extract File Partition";
                btnExtractCXI.Text = "Extract .CXI File";
                label2.Text = "Report";
                label1.Text = "Write the file name (Without Extension)";
                lblStatus.Text = "Status";
                btnLang.Text = "Change Language";
            }

        }

        private async void btnExtractCIA_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string nomeArquivo = txtNomeArquivo.Text.Trim();

            if (nomeArquivo.EndsWith(".cia", StringComparison.OrdinalIgnoreCase))
            {
                nomeArquivo = Path.GetFileNameWithoutExtension(nomeArquivo);
            }

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                string datas = File.ReadAllText(cam);
                if (datas == "EN")
                {
                    MessageBox.Show("Please enter the name of the .CIA file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "ES")
                {
                    MessageBox.Show("Por favor, introduzca el nombre del archivo .CIA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "KO")
                {
                    MessageBox.Show(".CIA 파일의 이름을 입력하세요!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "JA")
                {
                    MessageBox.Show(".CIAファイルの名前を入力してください！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "AL")
                {
                    MessageBox.Show("Bitte geben Sie den Namen der .CIA-Datei ein!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "IT")
                {
                    MessageBox.Show("Inserisci il nome del file .CIA!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "FR")
                {
                    MessageBox.Show("Veuillez saisir le nom du fichier .CIA !", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "CH")
                {
                    MessageBox.Show("请输入.CIA文件的名称！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "PT")
                {
                    MessageBox.Show("Por favor, digite o nome do arquivo .CIA!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Please enter the name of the .CIA file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                    SetUIState(true);
                return;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoCia = Path.Combine(baseDir, $"{nomeArquivo}.cia");

            if (!File.Exists(caminhoCia))
            {
                string dataa = File.ReadAllText(cam);
                if (dataa == "EN")
                {
                    MessageBox.Show(".CIA file not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "ES")
                {
                    MessageBox.Show("¡Archivo .CIA no encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "KO")
                {
                    MessageBox.Show(".CIA 파일을 찾을 수 없습니다!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "JA")
                {
                    MessageBox.Show(".CIAファイルが見つかりません！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "AL")
                {
                    MessageBox.Show(".CIA-Datei nicht gefunden!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "IT")
                {
                    MessageBox.Show("File .CIA non trovato!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "FR")
                {
                    MessageBox.Show("Fichier .CIA introuvable !", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "CH")
                {
                    MessageBox.Show("未找到.CIA文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "PT")
                {
                    MessageBox.Show($"Arquivo .CIA não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(".CIA file not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                SetUIState(true);
                return;
            }

            string datalog = File.ReadAllText(cam);
            if (datalog == "EN")
            {
                lblStatus.Text = "Starting .CIA extraction";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Iniciando la extracción del archivo .CIA";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = ".CIA 파일 추출 시작";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = ".CIAファイルの抽出を開始します";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = ".CIA-Extraktion wird gestartet";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Avvio dell'estrazione del file .CIA";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Démarrage de l'extraction .CIA";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "开始提取.CIA文件";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Iniciando extração do .CIA";

            }
            else
            {
                lblStatus.Text = "Starting .CIA extraction";
            }
            txtLog.AppendText($"[INFO]: Analyzing and extracting {nomeArquivo}.cia...\r\n");

            string argsStage1 = $"-xvtf cia \"{nomeArquivo}.cia\" --header HeaderCIA.bin --certs Certs.bin --tik Ticket.bin --tmd TMD.bin --content DecryptedPartition0.bin";
            bool sucesso1 = await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

            if (!sucesso1 || !File.Exists(Path.Combine(baseDir, "DecryptedPartition0.bin")))
            {
                
                txtLog.AppendText("[ERROR]: The .CIA file is invalid, corrupted, or encrypted.\r\n");
                string datal = File.ReadAllText(cam);
                if (datal == "EN")
                {
                    MessageBox.Show("Unable to process the .CIA file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "ES")
                {
                    MessageBox.Show("No se pudo procesar el archivo .CIA. Compruebe si el archivo está dañado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "KO")
                {
                    MessageBox.Show(".CIA 파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "JA")
                {
                    MessageBox.Show(".CIAファイルを処理できませんでした。ファイルが破損していないか確認してください。", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "AL")
                {
                    MessageBox.Show("Die .CIA-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "IT")
                {
                    MessageBox.Show("Impossibile elaborare il file .CIA. Verificare se il file è danneggiato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "FR")
                {
                    MessageBox.Show("Le fichier .CIA n'a pas pu être traité. Veuillez vérifier s'il est corrompu.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "CH")
                {
                    MessageBox.Show("无法处理 .CIA 文件。请检查文件是否已损坏。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "PT")
                {
                    MessageBox.Show("Não foi possível processar o arquivo .CIA. Verifique se o arquivo não está corrompido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Unable to process the .CIA file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                SetUIState(true);
                return;
            }

            
            if (datalog == "EN")
            {
                lblStatus.Text = "Extracting NCCH partition...";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Extrayendo la partición NCCH...";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = "NCCH 파티션을 추출하는 중...";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = "NCCHパーティションを抽出しています...";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = "NCCH-Partition wird extrahiert...";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Estrazione della partizione NCCH...";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Extraction de la partition NCCH...";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "正在提取 NCCH 分区...";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Extraindo partição NCCH...";

            }
            else
            {
                lblStatus.Text = "Extracting NCCH partition...";
            }
            string argsStage2 = "-xvtf cxi DecryptedPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
            await ExecutarFerramentaAsync("3dstool.exe", argsStage2);

            DeletarSeExistir(Path.Combine(baseDir, "DecryptedPartition0.bin"));

            lblStatus.Text = "ExeFS/RomFS extraction...";
            if (File.Exists(Path.Combine(baseDir, "DecryptedExeFS.bin")))
            {
                await ExecutarFerramentaAsync("3dstool.exe", "-xvtfu exefs DecryptedExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");
            }

            if (File.Exists(Path.Combine(baseDir, "DecryptedRomFS.bin")))
            {
                await ExecutarFerramentaAsync("3dstool.exe", "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS");
            }

            await Task.Run(() => OrganizarArquivosBannerSeguro());

            if (datalog == "EN")
            {
                lblStatus.Text = "Process Completed";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Processo Completado";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = "프로세스 완료됨";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = "処理が完了しました";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = "Prozess abgeschlossen";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Processo Completato";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Processus terminé";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "流程已完成";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Processo finalizado!";

            }
            else
            {
                lblStatus.Text = "Process Completed";
            }
            string data = File.ReadAllText(cam);
            if (data == "EN")
            {
                MessageBox.Show("Process Completed", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "ES")
            {
                MessageBox.Show("Processo Completado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "KO")
            {
                MessageBox.Show("프로세스 완료됨", "완전한", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "JA")
            {
                MessageBox.Show("処理が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "AL")
            {
                MessageBox.Show("Prozess abgeschlossen", "Vollendet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "IT")
            {
                MessageBox.Show("Processo Completato", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "FR")
            {
                MessageBox.Show("Processus terminé", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "CH")
            {
                MessageBox.Show("流程已完成", "完全的", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "PT")
            {
                MessageBox.Show("Processo finalizado!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Process Completed.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            SetUIState(true);
        }

        private void OrganizarArquivosBannerSeguro()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string pathExeFS = Path.Combine(baseDir, "ExtractedExeFS");
                string pathBanner = Path.Combine(baseDir, "ExtractedBanner");

                if (File.Exists(Path.Combine(pathExeFS, "banner.bnr")))
                    SafeRename(Path.Combine(pathExeFS, "banner.bnr"), "banner.bin");

                if (File.Exists(Path.Combine(pathExeFS, "icon.icn")))
                    SafeRename(Path.Combine(pathExeFS, "icon.icn"), "icon.bin");

                if (File.Exists(Path.Combine(pathExeFS, "banner.bin")))
                    File.Copy(Path.Combine(pathExeFS, "banner.bin"), Path.Combine(baseDir, "banner.bin"), true);

                string caminhoApp = Path.Combine(baseDir, "AppFiles", "3dstool.exe");
                if (File.Exists(caminhoApp) && File.Exists(Path.Combine(baseDir, "banner.bin")))
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = caminhoApp,
                        Arguments = "-xv -t banner -f banner.bin --banner-dir ExtractedBanner\\",
                        WorkingDirectory = baseDir,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };
                    using (Process p = Process.Start(psi))
                    {
                        p?.WaitForExit(5000); 
                    }
                }

                DeletarSeExistir(Path.Combine(baseDir, "banner.bin"));

                if (File.Exists(Path.Combine(pathBanner, "banner0.bcmdl")))
                    SafeRename(Path.Combine(pathBanner, "banner0.bcmdl"), "banner.cgfx");
            }
            catch { }
        }

        private async void btnRebuildCIA_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            string outputFilename = txtNomeArquivo.Text.Trim();

            if (outputFilename.EndsWith(".cia", StringComparison.OrdinalIgnoreCase))
            {
                outputFilename = Path.GetFileNameWithoutExtension(outputFilename);
            }

            if (string.IsNullOrEmpty(outputFilename))
            {
                outputFilename = "Game_Edited";
            }

            SetUIState(false);
            string datalog = File.ReadAllText(cam);
            if (datalog == "EN")
            {
                lblStatus.Text = "Starting .CIA rebuild";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Iniciando la compilación del archivo .CIA";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = ".CIA 컴파일 시작";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = ".CIAファイルのコンパイルを開始します。";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = ".CIA-Kompilierung wird gestartet";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Avvio della compilazione del file .CIA";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Début de la compilation .CIA";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "开始 .CIA 编译";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Iniciando compilação do .CIA";

            }
            else
            {
                lblStatus.Text = "Starting .CIA rebuild";
            }
            txtLog.AppendText($"[INFO]: Starting the {outputFilename}.cia packaging process ...\r\n");

            try
            {
                bool sucesso = await ExecuteRebuildCIAPipelineAsync(outputFilename);

                if (sucesso)
                {
                    if (datalog == "EN")
                    {
                        lblStatus.Text = "Process Completed";

                    }
                    else if (datalog == "ES")
                    {
                        lblStatus.Text = "Processo Completado";

                    }
                    else if (datalog == "KO")
                    {
                        lblStatus.Text = "프로세스 완료됨";

                    }
                    else if (datalog == "JA")
                    {
                        lblStatus.Text = "処理が完了しました";

                    }
                    else if (datalog == "AL")
                    {
                        lblStatus.Text = "Prozess abgeschlossen";

                    }
                    else if (datalog == "IT")
                    {
                        lblStatus.Text = "Processo Completato";

                    }
                    else if (datalog == "FR")
                    {
                        lblStatus.Text = "Processus terminé";

                    }
                    else if (datalog == "CH")
                    {
                        lblStatus.Text = "流程已完成";

                    }
                    else if (datalog == "PT")
                    {
                        lblStatus.Text = "Processo finalizado!";

                    }
                    else
                    {
                        lblStatus.Text = "Process Completed";
                    }
                    string data = File.ReadAllText(cam);
                    if (data == "EN")
                    {
                        MessageBox.Show($"Process Completed\n{outputFilename}_Edited.cia", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "ES")
                    {
                        MessageBox.Show($"Processo Completado\n{outputFilename}_Edited.cia", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "KO")
                    {
                        MessageBox.Show($"프로세스 완료됨\n{outputFilename}_Edited.cia", "완전한", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "JA")
                    {
                        MessageBox.Show($"処理が完了しました\n{outputFilename}_Edited.cia", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "AL")
                    {
                        MessageBox.Show($"Prozess abgeschlossen\n{outputFilename}_Edited.cia", "Vollendet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "IT")
                    {
                        MessageBox.Show($"Processo Completato\n{outputFilename}_Edited.cia", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "FR")
                    {
                        MessageBox.Show($"Processus terminé\n{outputFilename}_Edited.cia", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "CH")
                    {
                        MessageBox.Show($"流程已完成\n{outputFilename}_Edited.cia", "完全的", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (data == "PT")
                    {
                        MessageBox.Show($"Processo finalizado!\n{outputFilename}_Edited.cia", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"Process Completed.\n{outputFilename}_Edited.cia", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    if (datalog == "EN")
                    {
                        lblStatus.Text = "Process Completed";

                    }
                    else if (datalog == "ES")
                    {
                        lblStatus.Text = "Processo Completado";

                    }
                    else if (datalog == "KO")
                    {
                        lblStatus.Text = "프로세스 완료됨";

                    }
                    else if (datalog == "JA")
                    {
                        lblStatus.Text = "処理が完了しました";

                    }
                    else if (datalog == "AL")
                    {
                        lblStatus.Text = "Prozess abgeschlossen";

                    }
                    else if (datalog == "IT")
                    {
                        lblStatus.Text = "Processo Completato";

                    }
                    else if (datalog == "FR")
                    {
                        lblStatus.Text = "Processus terminé";

                    }
                    else if (datalog == "CH")
                    {
                        lblStatus.Text = "流程已完成";

                    }
                    else if (datalog == "PT")
                    {
                        lblStatus.Text = "Processo finalizado!";

                    }
                    else
                    {
                        lblStatus.Text = "Process Completed";
                    }
                    string datal = File.ReadAllText(cam);
                    if (datal == "EN")
                    {
                        MessageBox.Show("Unable to process the .CIA file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "ES")
                    {
                        MessageBox.Show("No se pudo procesar el archivo .CIA. Compruebe si el archivo está dañado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "KO")
                    {
                        MessageBox.Show(".CIA 파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "JA")
                    {
                        MessageBox.Show(".CIAファイルを処理できませんでした。ファイルが破損していないか確認してください。", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "AL")
                    {
                        MessageBox.Show("Die .CIA-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "IT")
                    {
                        MessageBox.Show("Impossibile elaborare il file .CIA. Verificare se il file è danneggiato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "FR")
                    {
                        MessageBox.Show("Le fichier .CIA n'a pas pu être traité. Veuillez vérifier s'il est corrompu.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "CH")
                    {
                        MessageBox.Show("无法处理 .CIA 文件。请检查文件是否已损坏。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (datal == "PT")
                    {
                        MessageBox.Show("Não foi possível processar o arquivo .CIA. Verifique se o arquivo não está corrompido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Unable to process the .CIA file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (datalog == "EN")
                {
                    lblStatus.Text = "Process Completed";

                }
                else if (datalog == "ES")
                {
                    lblStatus.Text = "Processo Completado";

                }
                else if (datalog == "KO")
                {
                    lblStatus.Text = "프로세스 완료됨";

                }
                else if (datalog == "JA")
                {
                    lblStatus.Text = "処理が完了しました";

                }
                else if (datalog == "AL")
                {
                    lblStatus.Text = "Prozess abgeschlossen";

                }
                else if (datalog == "IT")
                {
                    lblStatus.Text = "Processo Completato";

                }
                else if (datalog == "FR")
                {
                    lblStatus.Text = "Processus terminé";

                }
                else if (datalog == "CH")
                {
                    lblStatus.Text = "流程已完成";

                }
                else if (datalog == "PT")
                {
                    lblStatus.Text = "Processo finalizado!";

                }
                else
                {
                    lblStatus.Text = "Process Completed";
                }
                string datal = File.ReadAllText(cam);
                if (datal == "EN")
                {
                    MessageBox.Show($"Unable to process the .CIA file. Check if the file is corrupted.\n{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "ES")
                {
                    MessageBox.Show($"No se pudo procesar el archivo .CIA. Compruebe si el archivo está dañado.\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "KO")
                {
                    MessageBox.Show($".CIA 파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.\n{ex.Message}", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "JA")
                {
                    MessageBox.Show($".CIAファイルを処理できませんでした。ファイルが破損していないか確認してください。\n{ex.Message}", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "AL")
                {
                    MessageBox.Show($"Die .CIA-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.\n{ex.Message}", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "IT")
                {
                    MessageBox.Show($"Impossibile elaborare il file .CIA. Verificare se il file è danneggiato.\n{ex.Message}", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "FR")
                {
                    MessageBox.Show($"Le fichier .CIA n'a pas pu être traité. Veuillez vérifier s'il est corrompu.\n{ex.Message}", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "CH")
                {
                    MessageBox.Show($"无法处理 .CIA 文件。请检查文件是否已损坏。\n{ex.Message}", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "PT")
                {
                    MessageBox.Show($"Não foi possível processar o arquivo .CIA. Verifique se o arquivo não está corrompido.\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show($"Unable to process the .CIA file. Check if the file is corrupted.\n{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            finally
            {
                SetUIState(true);
            }
        }

        private async Task<bool> ExecuteRebuildCIAPipelineAsync(string outputName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string pathRomFS = Path.Combine(baseDir, "ExtractedRomFS");
            string pathExeFS = Path.Combine(baseDir, "ExtractedExeFS");
            string pathHeaderNCCH = Path.Combine(baseDir, "HeaderNCCH0.bin");

            if (!Directory.Exists(pathRomFS) && !Directory.Exists(pathExeFS))
            {
                txtLog.AppendText("[CRITICAL_ERROR]: The folders 'ExtractedRomFS' and 'ExtractedExeFS' wasn't found\\in this folder!\r\n");
                return false;
            }

            if (!File.Exists(pathHeaderNCCH))
            {
                txtLog.AppendText("[CRITICAL_ERROR]: 'HeaderNCCH0.bin' wasn't found!\r\n");
                return false;
            }

            if (Directory.Exists(Path.Combine(baseDir, "ExtractedBanner")))
            {
                SafeRename(Path.Combine(baseDir, @"ExtractedBanner\banner.cgfx"), "banner0.bcmdl");
                await ExecutarFerramentaAsync("3dstool.exe", "-cv -t banner -f banner.bin --banner-dir ExtractedBanner\\");
                SafeRename(Path.Combine(baseDir, @"ExtractedBanner\banner0.bcmdl"), "banner.cgfx");

                string bannerBin = Path.Combine(baseDir, "banner.bin");
                string targetBanner = Path.Combine(baseDir, @"ExtractedExeFS\banner.bin");
                if (File.Exists(bannerBin))
                {
                    File.Copy(bannerBin, targetBanner, overwrite: true);
                    DeletarSeExistir(bannerBin);
                }
            }

            if (Directory.Exists(pathExeFS))
            {
                txtLog.AppendText("[INFO]: Rebuiliding folder ExtractedExeFS...\r\n");
                SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\banner.bin"), "banner.bnr");
                SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\icon.bin"), "icon.icn");

                await ExecutarFerramentaAsync("3dstool.exe", "-cvtfz exefs CustomExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");

                SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\banner.bnr"), "banner.bin");
                SafeRename(Path.Combine(baseDir, @"ExtractedExeFS\icon.icn"), "icon.bin");
            }

            if (Directory.Exists(pathRomFS))
            {
                txtLog.AppendText("[INFO]: Rebuilding folder ExtractedRomFS...\r\n");
                await ExecutarFerramentaAsync("3dstool.exe", "-cvtf romfs CustomRomFS.bin --romfs-dir ExtractedRomFS");
            }

            txtLog.AppendText("[INFO]: Packaging the principal partition NCCH (CustomPartition0.bin)...\r\n");
            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cxi CustomPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs CustomExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs CustomRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin");

            FileInfo customPart0 = new FileInfo(Path.Combine(baseDir, "CustomPartition0.bin"));
            if (!customPart0.Exists || customPart0.Length <= 20000)
            {
                txtLog.AppendText("[ERROR]: 'CustomPartition0.bin' wasn't generated.\r\n");
                return false;
            }

            string targetCiaName = $"{outputName}_Edited.cia";
            bool resultadoFinal = false;

            if (File.Exists(Path.Combine(baseDir, "AppFiles", "makerom.exe")))
            {
                txtLog.AppendText("[INFO]: Generating .CIA file...\r\n");
                resultadoFinal = await ExecutarFerramentaAsync("makerom.exe", $"-f cia -o \"{targetCiaName}\" -content CustomPartition0.bin:0:0x05");
            }
            else
            {
                txtLog.AppendText("[INFO]: enerating .CIA file...\r\n");
                resultadoFinal = await ExecutarFerramentaAsync("3dstool.exe", $"-cvt01267f cia CustomPartition0.bin \"{targetCiaName}\" --header HeaderCIA.bin --certs Certs.bin --tik Ticket.bin --tmd TMD.bin");
            }

            string[] tempBins = { "CustomPartition0.bin", "CustomRomFS.bin", "CustomExeFS.bin" };
            foreach (var file in tempBins)
            {
                DeletarSeExistir(Path.Combine(baseDir, file));
            }

            return resultadoFinal;
        }

        private async void btnMassExtract_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string[] arquivos3ds = Directory.GetFiles(baseDir, "*.3ds");
            string[] arquivosCia = Directory.GetFiles(baseDir, "*.cia");

            int totalArquivos = arquivos3ds.Length + arquivosCia.Length;

            if (totalArquivos == 0)
            {
                string datares = File.ReadAllText(cam);
                if (datares == "EN")
                {
                    MessageBox.Show("No .3DS or .CIA file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "ES")
                {
                    MessageBox.Show("No se encontró ningún archivo .3DS o .CIA en esta carpeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "KO")
                {
                    MessageBox.Show("이 폴더에서 .3DS 또는 .CIA 파일을 찾을 수 없습니다.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "JA")
                {
                    MessageBox.Show("このフォルダに .3DS または .CIA ファイルは見つかりませんでした", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "AL")
                {
                    MessageBox.Show("In diesem Ordner wurde keine .3DS- oder .CIA-Datei gefunden.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "IT")
                {
                    MessageBox.Show("Non è stato trovato alcun file .3DS o .CIA in questa cartella.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "FR")
                {
                    MessageBox.Show("Aucun fichier .3DS ou .CIA n'a été trouvé dans ce dossier.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "CH")
                {
                    MessageBox.Show("在此文件夹中未找到 .3DS 或 .CIA 文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "PT")
                {
                    MessageBox.Show("Nenhum arquivo .3DS ou .CIA foram encontrados na pasta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("No .3DS or .CIA file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SetUIState(true);
                return;
            }
            string bdata = File.ReadAllText(cam);
            if(bdata == "PT")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Foram encontrados {totalArquivos} arquivo(s) para extração ({arquivos3ds.Length} .3DS e {arquivosCia.Length} .CIA).\n\nDeseja iniciar a extração massiva?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "EN")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Was found {totalArquivos} file(s) to mass extraction ({arquivos3ds.Length} .3DS and {arquivosCia.Length} .CIA).\n\nAre you want start?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "ES")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Fueron encontrados {totalArquivos} archivos para extrracción masiva ({arquivos3ds.Length} .3DS y {arquivosCia.Length} .CIA).\n\n¿Quieres empezar?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "FR")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"{totalArquivos} fichiers ont été trouvés pour une extraction en masse. ({arquivos3ds.Length} .3DS et {arquivosCia.Length} .CIA).\n\nVous voulez commencer ?",
                "Avis",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "IT")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Sono stati trovati {totalArquivos} file per l'estrazione di massa. ({arquivos3ds.Length} .3DS e {arquivosCia.Length} .CIA).\n\nVuoi iniziare?",
                "Avviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "AL")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Für die Massenextraktion wurden {totalArquivos} Dateien gefunden. ({arquivos3ds.Length} .3DS und {arquivosCia.Length} .CIA).\n\nMöchten Sie loslegen?",
                "Beachten",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "KO")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"일괄 추출을 위해 {totalArquivos}개의 파일이 발견되었습니다. ({arquivos3ds.Length} .3DS 및 {arquivosCia.Length} .CIA).\n\n시작하시겠습니까?",
                "시작하시겠습니까?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "JA")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"一括抽出対象として{totalArquivos}個のファイルが見つかりました ({arquivos3ds.Length} .3DS と {arquivosCia.Length} .CIA).\n\nさあ、始めましょうか？",
                "さあ、始めましょうか？",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else if (bdata == "CH")
            {
                DialogResult confirmacao = MessageBox.Show(
                $"共找到 {totalArquivos} 个文件用于批量提取 ({arquivos3ds.Length} .3DS 和 {arquivosCia.Length} .CIA).\n\n你想开始吗？",
                "你想开始吗？",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }
            else
            {
                DialogResult confirmacao = MessageBox.Show(
                $"Was found {totalArquivos} file(s) to mass extraction ({arquivos3ds.Length} .3DS and {arquivosCia.Length} .CIA).\n\nAre you want start?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    SetUIState(true);
                    return;
                }
            }




                txtLog.AppendText($"[MASS EXTRACT]: Starting the processment of {totalArquivos} files...\r\n\n");

            int processadosComSucesso = 0;

            foreach (string arquivo in arquivos3ds)
            {
                string nomeSemExtensao = Path.GetFileNameWithoutExtension(arquivo);
                string datalog = File.ReadAllText(cam);
                if (datalog == "EN")
                {
                    lblStatus.Text = $"Starting .3DS extraction --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "ES")
                {
                    lblStatus.Text = $"Iniciando la extracción del archivo .3DS --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "KO")
                {
                    lblStatus.Text = $".3DS 파일 추출 시작 --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "JA")
                {
                    lblStatus.Text = $".3DSファイルの抽出を開始します --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "AL")
                {
                    lblStatus.Text = $".3DS-Extraktion wird gestartet --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "IT")
                {
                    lblStatus.Text = $"Avvio dell'estrazione del file .3DS --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "FR")
                {
                    lblStatus.Text = $"Démarrage de l'extraction .3DS --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "CH")
                {
                    lblStatus.Text = $"开始提取.3DS文件 --- {nomeSemExtensao}.3ds";

                }
                else if (datalog == "PT")
                {
                    lblStatus.Text = $"Iniciando extração do .3DS --- {nomeSemExtensao}.3ds";

                }
                else
                {
                    lblStatus.Text = $"Starting .3DS extraction --- {nomeSemExtensao}.3ds";
                }
                txtLog.AppendText($">>> PROCESSING FILE: {nomeSemExtensao}.3ds <<<\r\n");

                bool sucesso = await ProcessarExtraicao3DSAsync(nomeSemExtensao);
                if (sucesso) processadosComSucesso++;

                txtLog.AppendText($"--------------------------------------------------\r\n\n");
            }

            foreach (string arquivo in arquivosCia)
            {
                string datalog = File.ReadAllText(cam);
                string nomeSemExtensao = Path.GetFileNameWithoutExtension(arquivo);
                if (datalog == "EN")
                {
                    lblStatus.Text = $"Starting .CIA extraction --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "ES")
                {
                    lblStatus.Text = $"Iniciando la extracción del archivo .CIA --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "KO")
                {
                    lblStatus.Text = $".CIA 파일 추출 시작 --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "JA")
                {
                    lblStatus.Text = $".CIAファイルの抽出を開始します --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "AL")
                {
                    lblStatus.Text = $".CIA-Extraktion wird gestartet --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "IT")
                {
                    lblStatus.Text = $"Avvio dell'estrazione del file .CIA --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "FR")
                {
                    lblStatus.Text = $"Démarrage de l'extraction .CIA --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "CH")
                {
                    lblStatus.Text = $"开始提取.CIA文件 --- {nomeSemExtensao}.cia";

                }
                else if (datalog == "PT")
                {
                    lblStatus.Text = $"Iniciando extração do .CIA --- {nomeSemExtensao}.cia";

                }
                else
                {
                    lblStatus.Text = $"Starting .CIA extraction --- {nomeSemExtensao}.cia";
                }
                txtLog.AppendText($">>> PROCESSING FILE: {nomeSemExtensao}.cia <<<\r\n");

                bool sucesso = await ProcessarExtraicaoCIAAsync(nomeSemExtensao);
                if (sucesso) processadosComSucesso++;

                txtLog.AppendText($"--------------------------------------------------\r\n\n");
            }
            string databros = File.ReadAllText(cam);
            if (databros == "EN")
            {
                lblStatus.Text = "Process Completed";

            }
            else if (databros == "ES")
            {
                lblStatus.Text = "Processo Completado";

            }
            else if (databros == "KO")
            {
                lblStatus.Text = "프로세스 완료됨";

            }
            else if (databros == "JA")
            {
                lblStatus.Text = "処理が完了しました";

            }
            else if (databros == "AL")
            {
                lblStatus.Text = "Prozess abgeschlossen";

            }
            else if (databros == "IT")
            {
                lblStatus.Text = "Processo Completato";

            }
            else if (databros == "FR")
            {
                lblStatus.Text = "Processus terminé";

            }
            else if (databros == "CH")
            {
                lblStatus.Text = "流程已完成";

            }
            else if (databros == "PT")
            {
                lblStatus.Text = "Processo finalizado!";

            }
            else
            {
                lblStatus.Text = "Process Completed";
            }
            string data = File.ReadAllText(cam);
            if (data == "EN")
            {
                MessageBox.Show($"Process Completed", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "ES")
            {
                MessageBox.Show($"Processo Completado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "KO")
            {
                MessageBox.Show($"프로세스 완료됨", "완전한", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "JA")
            {
                MessageBox.Show($"処理が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "AL")
            {
                MessageBox.Show($"Prozess abgeschlossen", "Vollendet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "IT")
            {
                MessageBox.Show($"Processo Completato", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "FR")
            {
                MessageBox.Show($"Processus terminé", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "CH")
            {
                MessageBox.Show($"流程已完成", "完全的", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (data == "PT")
            {
                MessageBox.Show($"Processo finalizado!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Process Completed.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SetUIState(true);
        }

        private async Task<bool> ProcessarExtraicao3DSAsync(string nomeArquivo)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string arquivo3ds = Path.Combine(baseDir, $"{nomeArquivo}.3ds");

            if (!File.Exists(arquivo3ds))
            {
                txtLog.AppendText($"[CRITICAL_ERROR]: The file {nomeArquivo}.3ds wasn't found.\r\n");
                return false;
            }
            string argsStage1 = $"-xvtf cci \"{nomeArquivo}.3ds\" --header HeaderNCSD.bin --content DecryptedPartition";
            bool ok1 = await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

            string decPart0 = Path.Combine(baseDir, "DecryptedPartition0.bin");

            if (!ok1 || !File.Exists(decPart0) || new FileInfo(decPart0).Length < 1000)
            {
                txtLog.AppendText($"[CRITICAL_ERROR]: {nomeArquivo}.3ds may be corrupted or invalid.\r\n");
                DeletarSeExistir(decPart0);
                return false;
            }

            string argsStage2 = "-xvtf cxi DecryptedPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
            await ExecutarFerramentaAsync("3dstool.exe", argsStage2);

            DeletarSeExistir(decPart0);

            string decExeFS = Path.Combine(baseDir, "DecryptedExeFS.bin");
            string decRomFS = Path.Combine(baseDir, "DecryptedRomFS.bin");

            if (!File.Exists(decExeFS) && !File.Exists(decRomFS))
            {
                txtLog.AppendText($"[CRITICAL_ERROR]: Não foi possível gerar os arquivos de ExeFS/RomFS para {nomeArquivo}.3ds.\r\n");
                return false;
            }

            if (File.Exists(decExeFS))
            {
                await ExecutarFerramentaAsync("3dstool.exe", $"-xvtfu exefs DecryptedExeFS.bin --exefs-dir Extracted_{nomeArquivo}_ExeFS --header HeaderExeFS.bin");
                DeletarSeExistir(decExeFS);
            }

            if (File.Exists(decRomFS))
            {
                await ExecutarFerramentaAsync("3dstool.exe", $"-xvtf romfs DecryptedRomFS.bin --romfs-dir Extracted_{nomeArquivo}_RomFS");
                DeletarSeExistir(decRomFS);
            }

            txtLog.AppendText($"[SUCESS]: {nomeArquivo}.3ds extraction was concluded with sucess!\r\n");
            return true;
        }

        private async Task<bool> ProcessarExtraicaoCIAAsync(string nomeArquivo)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string argsStage1 = $"-xvtf cia \"{nomeArquivo}.cia\" --header HeaderCIA.bin --certs Certs.bin --tik Ticket.bin --tmd TMD.bin --content DecryptedPartition0.bin";
            bool ok1 = await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

            if (!ok1 || !File.Exists(Path.Combine(baseDir, "DecryptedPartition0.bin"))) return false;

            string argsStage2 = "-xvtf cxi DecryptedPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
            await ExecutarFerramentaAsync("3dstool.exe", argsStage2);

            DeletarSeExistir(Path.Combine(baseDir, "DecryptedPartition0.bin"));

            if (File.Exists(Path.Combine(baseDir, "DecryptedExeFS.bin")))
            {
                await ExecutarFerramentaAsync("3dstool.exe", $"-xvtfu exefs DecryptedExeFS.bin --exefs-dir Extracted_{nomeArquivo}_ExeFS --header HeaderExeFS.bin");
            }

            if (File.Exists(Path.Combine(baseDir, "DecryptedRomFS.bin")))
            {
                await ExecutarFerramentaAsync("3dstool.exe", $"-xvtf romfs DecryptedRomFS.bin --romfs-dir Extracted_{nomeArquivo}_RomFS");
            }

            return true;
        }

        private async void btnMassRebuild_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            var pastas = Directory.GetDirectories(baseDir, "Extracted_*");

            HashSet<string> projetos = new HashSet<string>();
            foreach (var pasta in pastas)
            {
                string nomePasta = Path.GetFileName(pasta);
                if (nomePasta.StartsWith("Extracted_") && (nomePasta.EndsWith("_RomFS") || nomePasta.EndsWith("_ExeFS")))
                {
                    string idProjeto = nomePasta.Replace("Extracted_", "").Replace("_RomFS", "").Replace("_ExeFS", "");
                    projetos.Add(idProjeto);
                }
            }

            if (projetos.Count == 0)
            {
                if (Directory.Exists(Path.Combine(baseDir, "ExtractedRomFS")) || Directory.Exists(Path.Combine(baseDir, "ExtractedExeFS")))
                {
                    projetos.Add("Padrao");
                }
            }

            if (projetos.Count == 0)
            {
                string datares = File.ReadAllText(cam);
                if (datares == "EN")
                {
                    MessageBox.Show("No ROM file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "ES")
                {
                    MessageBox.Show("No se encontró ningún archivo ROM en esta carpeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "KO")
                {
                    MessageBox.Show("이 폴더에서 ROM 파일을 찾을 수 없습니다.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "JA")
                {
                    MessageBox.Show("このフォルダに ROM ファイルは見つかりませんでした", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "AL")
                {
                    MessageBox.Show("In diesem Ordner wurde keine ROM-Datei gefunden.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "IT")
                {
                    MessageBox.Show("Non è stato trovato alcun file ROM in questa cartella.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "FR")
                {
                    MessageBox.Show("Aucun fichier ROM n'a été trouvé dans ce dossier.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "CH")
                {
                    MessageBox.Show("在此文件夹中未找到 ROM 文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "PT")
                {
                    MessageBox.Show("Nenhum arquivo ROM foi encontrado na pasta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("No ROM file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SetUIState(true);
                return;
            }

           
                


            txtLog.AppendText($"[MASS REBUILD]: Starting a lot compilation {projetos.Count} project(s)...\r\n\n");

            int sucessos = 0;

            foreach (string proj in projetos)
            {
                lblStatus.Text = $"Rebuilding project: {proj}...";
                txtLog.AppendText($">>> REBUILDING PROJECT: {proj} <<<\r\n");

                bool resultado = await ProcessarRebuildMassivoAsync(proj);
                if (resultado)
                {
                    sucessos++;
                    txtLog.AppendText($"[SUCESS]: Project {proj} was rebuild with sucess!\r\n");
                }
                else
                {
                    txtLog.AppendText($"[ERROR]: Wasn't possible rebuild the project {proj}.\r\n");
                }

                txtLog.AppendText($"--------------------------------------------------\r\n\n");
            }

            
            

            SetUIState(true);
        }

        private async Task<bool> ProcessarRebuildMassivoAsync(string nomeProjeto)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string dirRomFS = nomeProjeto == "Padrao" ? Path.Combine(baseDir, "ExtractedRomFS") : Path.Combine(baseDir, $"Extracted_{nomeProjeto}_RomFS");
            string dirExeFS = nomeProjeto == "Padrao" ? Path.Combine(baseDir, "ExtractedExeFS") : Path.Combine(baseDir, $"Extracted_{nomeProjeto}_ExeFS");

            string headerNCCH = Path.Combine(baseDir, "HeaderNCCH0.bin");
            string headerNCSD = Path.Combine(baseDir, "HeaderNCSD.bin");

            if (!File.Exists(headerNCCH) || !File.Exists(headerNCSD))
            {
                txtLog.AppendText($"[CRITICAL ERROR]: Header files (HeaderNCCH0.bin/HeaderNCSD.bin) aren't on this\\folder!\r\n");
                return false;
            }


            if (Directory.Exists(dirExeFS))
            {
                SafeRename(Path.Combine(dirExeFS, "banner.bin"), "banner.bnr");
                SafeRename(Path.Combine(dirExeFS, "icon.bin"), "icon.icn");

                await ExecutarFerramentaAsync("3dstool.exe", $"-cvtfz exefs CustomExeFS.bin --exefs-dir \"{dirExeFS}\" --header HeaderExeFS.bin");

                SafeRename(Path.Combine(dirExeFS, "banner.bnr"), "banner.bin");
                SafeRename(Path.Combine(dirExeFS, "icon.icn"), "icon.bin");
            }

            if (Directory.Exists(dirRomFS))
            {
                await ExecutarFerramentaAsync("3dstool.exe", $"-cvtf romfs CustomRomFS.bin --romfs-dir \"{dirRomFS}\"");
            }

            await ExecutarFerramentaAsync("3dstool.exe", "-cvtf cxi CustomPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs CustomExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs CustomRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin");

            FileInfo customPart0 = new FileInfo(Path.Combine(baseDir, "CustomPartition0.bin"));
            if (!customPart0.Exists || customPart0.Length <= 20000)
            {
                txtLog.AppendText($"[ERROR]: Error on CustomPartition0.bin file generation to {nomeProjeto}.\r\n");
                return false;
            }

            string outputFileName = nomeProjeto == "Padrao" ? "MassRebuild_Edited.3ds" : $"{nomeProjeto}_Edited.3ds";
            bool resultadoFinal = await ExecutarFerramentaAsync("3dstool.exe", $"-cvt01267f cci CustomPartition0.bin \"{outputFileName}\" --header HeaderNCSD.bin");

            string[] tempBins = { "CustomPartition0.bin", "CustomRomFS.bin", "CustomExeFS.bin" };
            foreach (var file in tempBins)
            {
                DeletarSeExistir(Path.Combine(baseDir, file));
            }

            FileInfo fileFinal = new FileInfo(Path.Combine(baseDir, outputFileName));
            return resultadoFinal && fileFinal.Exists && fileFinal.Length > 1000000;
        }

        private async void btnExtractBanner_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string bannerRaiz = Path.Combine(baseDir, "banner.bin");
            string bannerExeFS = Path.Combine(baseDir, @"ExtractedExeFS\banner.bin");

            string bannerTarget = string.Empty;

            if (File.Exists(bannerRaiz))
            {
                bannerTarget = bannerRaiz;
            }
            else if (File.Exists(bannerExeFS))
            {
                bannerTarget = bannerExeFS;
            }

            if (string.IsNullOrEmpty(bannerTarget))
            {
                string datares = File.ReadAllText(cam);
                if (datares == "EN")
                {
                    MessageBox.Show("No 'banner.bin' file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "ES")
                {
                    MessageBox.Show("No se encontró ningún archivo 'banner.bin' en esta carpeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "KO")
                {
                    MessageBox.Show("이 폴더에서 'banner.bin' 파일을 찾을 수 없습니다.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "JA")
                {
                    MessageBox.Show("このフォルダに 'banner.bin' ファイルは見つかりませんでした", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "AL")
                {
                    MessageBox.Show("In diesem Ordner wurde keine banner.bin-Datei gefunden.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "IT")
                {
                    MessageBox.Show("Non è stato trovato alcun file 'banner.bin' in questa cartella.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "FR")
                {
                    MessageBox.Show("Aucun fichier 'banner.bin' n'a été trouvé dans ce dossier.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "CH")
                {
                    MessageBox.Show("在此文件夹中未找到 'banner.bin' 文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "PT")
                {
                    MessageBox.Show("Nenhum arquivo 'banner.bin' foi encontrado na pasta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("No 'banner.bin' file was found in this folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SetUIState(true);
                return;
            }

            txtLog.AppendText("[INFO]: Starting the Banner extraction...\r\n");
            lblStatus.Text = "banner.bin extraction...";

            bool copiadoParaRaiz = false;
            if (bannerTarget == bannerExeFS)
            {
                File.Copy(bannerExeFS, bannerRaiz, overwrite: true);
                copiadoParaRaiz = true;
            }

            string outDir = Path.Combine(baseDir, "ExtractedBanner");
            if (!Directory.Exists(outDir))
            {
                Directory.CreateDirectory(outDir);
            }

            bool resultado = await ExecutarFerramentaAsync("3dstool.exe", "-unv -t banner -f banner.bin --banner-dir ExtractedBanner\\");

            SafeRename(Path.Combine(outDir, "banner0.bcmdl"), "banner.cgfx");

            if (copiadoParaRaiz)
            {
                DeletarSeExistir(bannerRaiz);
            }

            if (resultado && Directory.GetFiles(outDir).Length > 0)
            {
                txtLog.AppendText("[SUCESS]: Banner was extracted to 'ExtractedBanner' folder!\r\n");
                string databros = File.ReadAllText(cam);
                if (databros == "EN")
                {
                    lblStatus.Text = "Process Completed";

                }
                else if (databros == "ES")
                {
                    lblStatus.Text = "Processo Completado";

                }
                else if (databros == "KO")
                {
                    lblStatus.Text = "프로세스 완료됨";

                }
                else if (databros == "JA")
                {
                    lblStatus.Text = "処理が完了しました";

                }
                else if (databros == "AL")
                {
                    lblStatus.Text = "Prozess abgeschlossen";

                }
                else if (databros == "IT")
                {
                    lblStatus.Text = "Processo Completato";

                }
                else if (databros == "FR")
                {
                    lblStatus.Text = "Processus terminé";

                }
                else if (databros == "CH")
                {
                    lblStatus.Text = "流程已完成";

                }
                else if (databros == "PT")
                {
                    lblStatus.Text = "Processo finalizado!";

                }
                else
                {
                    lblStatus.Text = "Process Completed";
                }
                if (databros == "EN")
                {
                    MessageBox.Show($"Process Completed", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "ES")
                {
                    MessageBox.Show($"Processo Completado", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "KO")
                {
                    MessageBox.Show($"프로세스 완료됨", "완전한", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "JA")
                {
                    MessageBox.Show($"処理が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "AL")
                {
                    MessageBox.Show($"Prozess abgeschlossen", "Vollendet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "IT")
                {
                    MessageBox.Show($"Processo Completato", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "FR")
                {
                    MessageBox.Show($"Processus terminé", "Complété", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "CH")
                {
                    MessageBox.Show($"流程已完成", "完全的", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (databros == "PT")
                {
                    MessageBox.Show($"Processo finalizado!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"Process Completed.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                txtLog.AppendText("[ERROR]: Failed to extract the file.\r\n");
                string datal = File.ReadAllText(cam);
                if (datal == "EN")
                {
                    MessageBox.Show($"Unable to process the file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "ES")
                {
                    MessageBox.Show($"No se pudo procesar el archivo. Compruebe si el archivo está dañado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "KO")
                {
                    MessageBox.Show($"파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "JA")
                {
                    MessageBox.Show($"ファイルを処理できませんでした。ファイルが破損していないか確認してください。", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "AL")
                {
                    MessageBox.Show($"Die .Banner-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "IT")
                {
                    MessageBox.Show($"Impossibile elaborare il file. Verificare se il file è danneggiato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "FR")
                {
                    MessageBox.Show($"Le fichier n'a pas pu être traité. Veuillez vérifier s'il est corrompu.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "CH")
                {
                    MessageBox.Show($"无法处理文件。请检查文件是否已损坏。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "PT")
                {
                    MessageBox.Show($"Não foi possível processar o arquivo. Verifique se o arquivo não está corrompido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show($"Unable to process the file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string databros = File.ReadAllText(cam);
                if (databros == "EN")
                {
                    lblStatus.Text = "Process Completed";

                }
                else if (databros == "ES")
                {
                    lblStatus.Text = "Processo Completado";

                }
                else if (databros == "KO")
                {
                    lblStatus.Text = "프로세스 완료됨";

                }
                else if (databros == "JA")
                {
                    lblStatus.Text = "処理が完了しました";

                }
                else if (databros == "AL")
                {
                    lblStatus.Text = "Prozess abgeschlossen";

                }
                else if (databros == "IT")
                {
                    lblStatus.Text = "Processo Completato";

                }
                else if (databros == "FR")
                {
                    lblStatus.Text = "Processus terminé";

                }
                else if (databros == "CH")
                {
                    lblStatus.Text = "流程已完成";

                }
                else if (databros == "PT")
                {
                    lblStatus.Text = "Processo finalizado";

                }
                else
                {
                    lblStatus.Text = "Process Completed";
                }

            }

            SetUIState(true);
        }

        private async void btnRebuildBanner_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string pathBannerDir = Path.Combine(baseDir, "ExtractedBanner");
            string pathExeFS = Path.Combine(baseDir, "ExtractedExeFS");

            if (!Directory.Exists(pathBannerDir) || Directory.GetFiles(pathBannerDir).Length == 0)
            {
                string datares = File.ReadAllText(cam);
                if (datares == "EN")
                {
                    MessageBox.Show("The 'ExtractedBanner' folder does not exist or is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "ES")
                {
                    MessageBox.Show("No se encontró ningún 'ExtractedBanner' en esta carpeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "KO")
                {
                    MessageBox.Show("이 폴더에서 'ExtractedBanner' 파일을 찾을 수 없습니다.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "JA")
                {
                    MessageBox.Show("このフォルダに 'ExtractedBanner' ファイルは見つかりませんでした", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "AL")
                {
                    MessageBox.Show("In diesem Ordner wurde keine ExtractedBanner-Datei gefunden.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "IT")
                {
                    MessageBox.Show("Non è stato trovato alcun 'ExtractedBanner' in questa cartella.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "FR")
                {
                    MessageBox.Show("Aucun 'ExtractedBanner' n'a été trouvé dans ce dossier.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "CH")
                {
                    MessageBox.Show("在此文件夹中未找到 'ExtractedBanner' 文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datares == "PT")
                {
                    MessageBox.Show("Nenhum diretório 'ExtractedBanner' foi encontrado na pasta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("The 'ExtractedBanner' folder does not exist or is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                SetUIState(true);
                return;
            }

            txtLog.AppendText("[INFO]: Rebuilding the ExtractedBanner's files...\r\n");
            lblStatus.Text = "Rebuilding banner.bin...";

            SafeRename(Path.Combine(pathBannerDir, "banner.cgfx"), "banner0.bcmdl");

            bool resultado = await ExecutarFerramentaAsync("3dstool.exe", "-cv -t banner -f banner.bin --banner-dir ExtractedBanner\\");
            SafeRename(Path.Combine(pathBannerDir, "banner0.bcmdl"), "banner.cgfx");

            string bannerGerado = Path.Combine(baseDir, "banner.bin");

            if (resultado && File.Exists(bannerGerado))
            {
                if (Directory.Exists(pathExeFS))
                {
                    string targetInExeFS = Path.Combine(pathExeFS, "banner.bin");
                    File.Copy(bannerGerado, targetInExeFS, overwrite: true);
                    txtLog.AppendText("[INFO]: Actualized!\r\n");
                }

                txtLog.AppendText("[SUCESS]\r\n");
                lblStatus.Text = "";
                MessageBox.Show("Sucess", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtLog.AppendText("[ERROR]");
                lblStatus.Text = "";
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetUIState(true);
        }

        private async void btnExtractNCCH_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string nomeArquivo = txtNomeArquivo.Text.Trim();

            if (nomeArquivo.EndsWith(".3ds", StringComparison.OrdinalIgnoreCase) ||
                nomeArquivo.EndsWith(".cia", StringComparison.OrdinalIgnoreCase))
            {
                nomeArquivo = Path.GetFileNameWithoutExtension(nomeArquivo);
            }

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                string datas = File.ReadAllText(cam);
                if (datas == "EN")
                {
                    MessageBox.Show("Please enter the name of the file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "ES")
                {
                    MessageBox.Show("Por favor, introduzca el nombre del archivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "KO")
                {
                    MessageBox.Show("파일의 이름을 입력하세요!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "JA")
                {
                    MessageBox.Show("ファイルの名前を入力してください！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "AL")
                {
                    MessageBox.Show("Bitte geben Sie den Namen der .3DS-Datei/.CIA-Datei ein!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "IT")
                {
                    MessageBox.Show("Inserisci il nome del file!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "FR")
                {
                    MessageBox.Show("Veuillez saisir le nom du fichier!", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "CH")
                {
                    MessageBox.Show("请输入文件的名称！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "PT")
                {
                    MessageBox.Show("Por favor, digite o nome do arquivo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Please enter the name of the file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                SetUIState(true);
                return;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string path3ds = Path.Combine(baseDir, $"{nomeArquivo}.3ds");
            string pathCia = Path.Combine(baseDir, $"{nomeArquivo}.cia");

            bool is3ds = File.Exists(path3ds);
            bool isCia = File.Exists(pathCia);

            if (!is3ds && !isCia)
            {
                MessageBox.Show($"The file '{nomeArquivo}.3ds' or '{nomeArquivo}.cia' wasn't found in this folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetUIState(true);
                return;
            }

            string idiom = File.ReadAllText(cam);
            
                string inputIndex = Microsoft.VisualBasic.Interaction.InputBox(
                "NCCH Partition Number:\n\n" +
                "0 = Principal Game (CXI)\n" +
                "1 = User Instructions (CFA)\n" +
                "2 = Download Play (CFA)\n" +
                "6 = N3DS Update (CFA)\n" +
                "7 = O3DS Update (CFA)",
                "Extract Partition NCCH", "0");
          
            

            if (string.IsNullOrWhiteSpace(inputIndex) || !int.TryParse(inputIndex, out int partitionIndex))
            {
                txtLog.AppendText("[CANCELED]\r\n");
                SetUIState(true);
                return;
            }

            txtLog.AppendText($"[INFO]: Extraindo partição NCCH {partitionIndex} do arquivo {nomeArquivo}...\r\n");
            lblStatus.Text = $"Extraindo Partição NCCH{partitionIndex}...";

            string modo = is3ds ? "cci" : "cia";
            string extensao = is3ds ? ".3ds" : ".cia";

            string arguments = $"-xvtf {modo} \"{nomeArquivo}{extensao}\" --header HeaderNCCH{partitionIndex}.bin --content DecryptedPartition{partitionIndex}.bin:{partitionIndex}";

            bool resultado = await ExecutarFerramentaAsync("3dstool.exe", arguments);

            string binGerado = Path.Combine(baseDir, $"DecryptedPartition{partitionIndex}.bin");

            if (resultado && File.Exists(binGerado) && new FileInfo(binGerado).Length > 1000)
            {
                txtLog.AppendText($"[SUCESS]\r\n");
                lblStatus.Text = "Sucess!";
                MessageBox.Show($"Sucess!\n\nDecryptedPartition{partitionIndex}.bin", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtLog.AppendText($"[ERROR]\r\n");
                lblStatus.Text = "Error";
                MessageBox.Show($"Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetUIState(true);
        }

        private async void btnExtractFilePartition_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string inputIndex = Microsoft.VisualBasic.Interaction.InputBox(
                "NCCH Partition Number:\n\n" +
                "0 = Full Game Partition (ExtractedExeFS / ExtractedRomFS)\n" +
                "1 = User's Manual Partition (ExtractedManual)\n" +
                "2 = Download Play Partition (ExtractedDownloadPlay)\n" +
                "6 = Update N3DS Partition (ExtractedN3DSUpdate)\n" +
                "7 = Update O3DS Partition (ExtractedO3DSUpdate)",
                "Extract File Partition", "0");

            if (string.IsNullOrWhiteSpace(inputIndex) || !int.TryParse(inputIndex, out int partitionIndex))
            {
                txtLog.AppendText("[CANCELED]\r\n");
                SetUIState(true);
                return;
            }

            string arquivoBin = Path.Combine(baseDir, $"DecryptedPartition{partitionIndex}.bin");

            if (!File.Exists(arquivoBin))
            {
                MessageBox.Show($"'DecryptedPartition{partitionIndex}.bin' wasn't found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetUIState(true);
                return;
            }

            txtLog.AppendText($"[INFO]: Extracting the file DecryptedPartition{partitionIndex}.bin...\r\n");
            lblStatus.Text = $"Estracting Partition {partitionIndex}...";

            bool sucesso = false;

            if (partitionIndex == 0)
            {
                string argsStage1 = "-xvtf cxi DecryptedPartition0.bin --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
                await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

                if (File.Exists(Path.Combine(baseDir, "DecryptedExeFS.bin")))
                {
                    await ExecutarFerramentaAsync("3dstool.exe", "-xvtfu exefs DecryptedExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");
                    DeletarSeExistir(Path.Combine(baseDir, "DecryptedExeFS.bin"));
                }

                if (File.Exists(Path.Combine(baseDir, "DecryptedRomFS.bin")))
                {
                    await ExecutarFerramentaAsync("3dstool.exe", "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS");
                    DeletarSeExistir(Path.Combine(baseDir, "DecryptedRomFS.bin"));
                }

                sucesso = Directory.Exists(Path.Combine(baseDir, "ExtractedRomFS")) || Directory.Exists(Path.Combine(baseDir, "ExtractedExeFS"));
            }
            else
            {
                string nomePastaDestino = "ExtractedManual";
                if (partitionIndex == 2) nomePastaDestino = "ExtractedDownloadPlay";
                else if (partitionIndex == 6) nomePastaDestino = "ExtractedN3DSUpdate";
                else if (partitionIndex == 7) nomePastaDestino = "ExtractedO3DSUpdate";

                string argsCfa = $"-xvtf cfa DecryptedPartition{partitionIndex}.bin --header HeaderNCCH{partitionIndex}.bin --romfs DecryptedRomFS{partitionIndex}.bin --romfs-auto-key";
                await ExecutarFerramentaAsync("3dstool.exe", argsCfa);

                string romfsBin = Path.Combine(baseDir, $"DecryptedRomFS{partitionIndex}.bin");
                if (File.Exists(romfsBin))
                {
                    await ExecutarFerramentaAsync("3dstool.exe", $"-xvtf romfs DecryptedRomFS{partitionIndex}.bin --romfs-dir {nomePastaDestino}");
                    DeletarSeExistir(romfsBin);
                }

                sucesso = Directory.Exists(Path.Combine(baseDir, nomePastaDestino));
            }

            if (sucesso)
            {
                txtLog.AppendText($"[SUCESS] {partitionIndex}.bin\r\n");
                lblStatus.Text = "";
                
            }
            else
            {
                txtLog.AppendText($"[ERROR] {partitionIndex}.bin.\r\n");
                lblStatus.Text = "";

            }

            SetUIState(true);
        }

        private async void btnExtractCXI_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            SetUIState(false);

            string nomeArquivo = txtNomeArquivo.Text.Trim();

            if (nomeArquivo.EndsWith(".cxi", StringComparison.OrdinalIgnoreCase) ||
                nomeArquivo.EndsWith(".ncch", StringComparison.OrdinalIgnoreCase))
            {
                nomeArquivo = Path.GetFileNameWithoutExtension(nomeArquivo);
            }

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                string datas = File.ReadAllText(cam);
                if (datas == "EN")
                {
                    MessageBox.Show("Please enter the name of the .CXI file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "ES")
                {
                    MessageBox.Show("Por favor, introduzca el nombre del archivo .CXI!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "KO")
                {
                    MessageBox.Show(".CXI 파일의 이름을 입력하세요!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "JA")
                {
                    MessageBox.Show(".CXIファイルの名前を入力してください！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "AL")
                {
                    MessageBox.Show("Bitte geben Sie den Namen der .CXI-Datei ein!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "IT")
                {
                    MessageBox.Show("Inserisci il nome del file .CXI!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "FR")
                {
                    MessageBox.Show("Veuillez saisir le nom du fichier .CXI !", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "CH")
                {
                    MessageBox.Show("请输入.CXI文件的名称！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (datas == "PT")
                {
                    MessageBox.Show("Por favor, digite o nome do arquivo .CXI!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Please enter the name of the .CXI file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SetUIState(true);
                return;
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            string caminhoCxi = Path.Combine(baseDir, $"{nomeArquivo}.cxi");
            string caminhoNcch = Path.Combine(baseDir, $"{nomeArquivo}.ncch");
            string arquivoAlvo = string.Empty;

            if (File.Exists(caminhoCxi))
            {
                arquivoAlvo = $"{nomeArquivo}.cxi";
            }
            else if (File.Exists(caminhoNcch))
            {
                arquivoAlvo = $"{nomeArquivo}.ncch";
            }
            else
            {
                string dataa = File.ReadAllText(cam);
                if (dataa == "EN")
                {
                    MessageBox.Show(".CXI file not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "ES")
                {
                    MessageBox.Show("¡Archivo .CXI no encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "KO")
                {
                    MessageBox.Show(".CXI 파일을 찾을 수 없습니다!", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "JA")
                {
                    MessageBox.Show(".CXIファイルが見つかりません！", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "AL")
                {
                    MessageBox.Show(".CXI-Datei nicht gefunden!", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "IT")
                {
                    MessageBox.Show("File .CXI non trovato!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "FR")
                {
                    MessageBox.Show("Fichier .CXI introuvable !", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "CH")
                {
                    MessageBox.Show("未找到.CXI文件", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dataa == "PT")
                {
                    MessageBox.Show($"Arquivo .CXI não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(".CXI file not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SetUIState(true);
                return;
            }

            string datalog = File.ReadAllText(cam);
            if (datalog == "EN")
            {
                lblStatus.Text = "Starting .CXI extraction";

            }
            else if (datalog == "ES")
            {
                lblStatus.Text = "Iniciando la extracción del archivo .CXI";

            }
            else if (datalog == "KO")
            {
                lblStatus.Text = ".CXI 파일 추출 시작";

            }
            else if (datalog == "JA")
            {
                lblStatus.Text = ".CXIファイルの抽出を開始します";

            }
            else if (datalog == "AL")
            {
                lblStatus.Text = ".CXI-Extraktion wird gestartet";

            }
            else if (datalog == "IT")
            {
                lblStatus.Text = "Avvio dell'estrazione del file .CXI";

            }
            else if (datalog == "FR")
            {
                lblStatus.Text = "Démarrage de l'extraction .CXI";

            }
            else if (datalog == "CH")
            {
                lblStatus.Text = "开始提取.CXI文件";

            }
            else if (datalog == "PT")
            {
                lblStatus.Text = "Iniciando extração do .CXI";

            }
            else
            {
                lblStatus.Text = "Starting .CXI extraction";
            }
            txtLog.AppendText($"[INFO]: Extracting the file {arquivoAlvo}...\r\n");

            string argsStage1 = $"-xvtf cxi \"{arquivoAlvo}\" --header HeaderNCCH0.bin --exh DecryptedExHeader.bin --exh-auto-key --exefs DecryptedExeFS.bin --exefs-auto-key --exefs-top-auto-key --romfs DecryptedRomFS.bin --romfs-auto-key --logo LogoLZ.bin --plain PlainRGN.bin";
            bool sucesso1 = await ExecutarFerramentaAsync("3dstool.exe", argsStage1);

            string decExeFS = Path.Combine(baseDir, "DecryptedExeFS.bin");
            string decRomFS = Path.Combine(baseDir, "DecryptedRomFS.bin");

            if (sucesso1 && (File.Exists(decExeFS) || File.Exists(decRomFS)))
            {
                

                if (File.Exists(decExeFS))
                {
                    await ExecutarFerramentaAsync("3dstool.exe", "-xvtfu exefs DecryptedExeFS.bin --exefs-dir ExtractedExeFS --header HeaderExeFS.bin");
                    DeletarSeExistir(decExeFS);
                }

                if (File.Exists(decRomFS))
                {
                    await ExecutarFerramentaAsync("3dstool.exe", "-xvtf romfs DecryptedRomFS.bin --romfs-dir ExtractedRomFS");
                    DeletarSeExistir(decRomFS);
                }

                await Task.Run(() => OrganizarArquivosBannerSeguro());

                lblStatus.Text = "";
                txtLog.AppendText("[SUCESS]\r\n");
                if (datalog == "EN")
                {
                    lblStatus.Text = "Process Completed";

                }
                else if (datalog == "ES")
                {
                    lblStatus.Text = "Processo Completado";

                }
                else if (datalog == "KO")
                {
                    lblStatus.Text = "프로세스 완료됨";

                }
                else if (datalog == "JA")
                {
                    lblStatus.Text = "処理が完了しました";

                }
                else if (datalog == "AL")
                {
                    lblStatus.Text = "Prozess abgeschlossen";

                }
                else if (datalog == "IT")
                {
                    lblStatus.Text = "Processo Completato";

                }
                else if (datalog == "FR")
                {
                    lblStatus.Text = "Processus terminé";

                }
                else if (datalog == "CH")
                {
                    lblStatus.Text = "流程已完成";

                }
                else if (datalog == "PT")
                {
                    lblStatus.Text = "Processo finalizado!";

                }
                else
                {
                    lblStatus.Text = "Process Completed";
                }
            }
            else
            {
                lblStatus.Text = "";
                txtLog.AppendText("[CRITICAL_ERROR]\r\n");
                string datal = File.ReadAllText(cam);
                if (datal == "EN")
                {
                    MessageBox.Show("Unable to process the .CXI file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "ES")
                {
                    MessageBox.Show("No se pudo procesar el archivo .CXI. Compruebe si el archivo está dañado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "KO")
                {
                    MessageBox.Show(".CXI 파일을 처리할 수 없습니다. 파일이 손상되었는지 확인하십시오.", "알아채다", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "JA")
                {
                    MessageBox.Show(".CXIファイルを処理できませんでした。ファイルが破損していないか確認してください。", "知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "AL")
                {
                    MessageBox.Show("Die .CXI-Datei konnte nicht verarbeitet werden. Bitte prüfen Sie, ob die Datei beschädigt ist.", "Beachten", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "IT")
                {
                    MessageBox.Show("Impossibile elaborare il file .CXI. Verificare se il file è danneggiato.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "FR")
                {
                    MessageBox.Show("Le fichier .CXI n'a pas pu être traité. Veuillez vérifier s'il est corrompu.", "Avis", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "CH")
                {
                    MessageBox.Show("无法处理 .CXI 文件。请检查文件是否已损坏。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (datal == "PT")
                {
                    MessageBox.Show("Não foi possível processar o arquivo .CXI. Verifique se o arquivo não está corrompido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Unable to process the .CXI file. Check if the file is corrupted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            SetUIState(true);
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }

        
    }
}