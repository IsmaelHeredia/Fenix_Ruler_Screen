// Fenix Ruler Screen 0.4
// © Ismael Heredia , Argentina , 2017
// Credits :
// Based on Screen Ruler By Zarko Gajic
// http://delphi.about.com/od/fullcodeprojects/ss/screen_ruler.htm
// Thanks to Zarko Gajic

unit ruler;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ComCtrls, Vcl.StdCtrls,
  Vcl.Imaging.GIFImg, Vcl.ExtCtrls, Vcl.Imaging.pngimage, Clipbrd, ShellApi,
  tlhelp32;

type
  TFormHome = class(TForm)
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet2: TTabSheet;
    StatusBar1: TStatusBar;
    GroupBox1: TGroupBox;
    txtSizes: TEdit;
    btnCopy: TButton;
    btnOpenRuler: TButton;
    GroupBox2: TGroupBox;
    imgAbout: TImage;
    btnHelp: TButton;
    mmOutput: TMemo;
    imgLogo: TImage;
    tmTimer: TTimer;
    txtPixels: TEdit;
    procedure btnCopyClick(Sender: TObject);
    procedure btnHelpClick(Sender: TObject);
    procedure btnOpenRulerClick(Sender: TObject);
    procedure tmTimerTimer(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormHome: TFormHome;

implementation

{$R *.dfm}

function verificar_proceso(este_proceso: string): string;

var
  conector: THandle;
  timbre: LongBool;
  indicio: TProcessEntry32;

begin

  conector := CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
  indicio.dwSize := SizeOf(indicio);
  timbre := Process32First(conector, indicio);

  while timbre do
  begin
    if (UpperCase(indicio.szExeFile) = UpperCase(este_proceso)) then
    begin
      Result := 'Yes';
    end;
    timbre := Process32Next(conector, indicio);
  end;

  CloseHandle(conector);

end;

procedure TFormHome.btnCopyClick(Sender: TObject);
begin
  Clipboard().AsText := txtSizes.Text;
end;

procedure TFormHome.btnOpenRulerClick(Sender: TObject);

begin

  ShellExecute(Handle, 'open', Pchar(ExtractFilePath(Application.ExeName) +
    '/Data/' + 'ruler_en_si.exe'), nil, nil, SW_SHOWNORMAL);

  tmTimer.Enabled := true;

end;

procedure TFormHome.btnHelpClick(Sender: TObject);
begin
  ShowMessage('In the ruler use control+t to save dimensions');
end;

procedure TFormHome.tmTimerTimer(Sender: TObject);
var
  contenido: TStringList;
  dividir_contenido: TStrings;
  leido: string;
begin

  if not(verificar_proceso('ruler_en_si.exe') = 'Yes') then
  begin
    if (FileExists(ExtractFilePath(Application.ExeName) + '/options.zzz')) then
    begin
      contenido := TStringList.Create;
      contenido.Loadfromfile(ExtractFilePath(Application.ExeName) +
        '/options.zzz');
      leido := contenido.Text;
      contenido.Free;

      dividir_contenido := TStringList.Create;
      ExtractStrings([':'], [], Pchar(leido), dividir_contenido);

      txtSizes.Text := dividir_contenido[0] + 'x' + dividir_contenido[1];
      txtPixels.Text := ' px';
      dividir_contenido.Free;

      DeleteFile(ExtractFilePath(Application.ExeName) + '/options.zzz');
    end;

    tmTimer.Enabled := false;
  end;

end;

end.
