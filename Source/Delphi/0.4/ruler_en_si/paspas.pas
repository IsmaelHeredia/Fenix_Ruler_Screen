// Fenix Ruler Screen 0.4
// © Ismael Heredia , Argentina , 2017
// Credits :
// Based on Screen Ruler By Zarko Gajic
// http://delphi.about.com/od/fullcodeprojects/ss/screen_ruler.htm
// Thanks to Zarko Gajic

unit paspas;

interface

uses
  inifiles, Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls,
  Forms, Dialogs, Menus, StdCtrls, ExtCtrls, MMSystem;

type

  TFormHome = class(TForm)
    tmTimer: TTimer;
    procedure FormCreate(Sender: TObject);
    procedure FormResize(Sender: TObject);
    procedure FormKeyUp(Sender: TObject; var Key: Word; Shift: TShiftState);

  private
    procedure WMNCHitTest(var var9: TWMNCHitTest); message wm_NCHitTest;
  protected
    procedure CreateParams(var comandos: TCreateParams); override;
  end;

var
  FormHome: TFormHome;
  width_global: string;
  height_global: string;

implementation

{$R *.dfm}

procedure TFormHome.CreateParams(var comandos: TCreateParams);
begin
  inherited CreateParams(comandos);
  comandos.Style := comandos.Style or WS_SIZEBOX;
end;

procedure TFormHome.WMNCHitTest(var var9: TWMNCHitTest);
begin
  inherited;
  if var9.Result = htClient then
  begin
    var9.Result := htCaption;
  end;
end;

procedure TFormHome.FormCreate(Sender: TObject);
begin
  Top := 187;
  Left := 414;
  Width := 259;
  Height := 106;
  AlphaBlend := true;
  AlphaBlendValue := 255 - Trunc((255 * 30) / 100);
end;

procedure TFormHome.FormKeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
var
  writer: TextFile;
begin
  if (Key = 84) and (Shift = [ssCtrl]) then
  begin

    if FileExists('options.zzz') then
    begin
      DeleteFile('options.zzz');
    end;

    AssignFile(writer, 'options.zzz');
    ReWrite(writer);
    WriteLn(writer, width_global + ':' + height_global);
    CloseFile(writer);

    PlaySound(Pchar(ExtractFilePath(Application.ExeName) + '/Data/scanfin.wav'),
      0, SND_ASYNC);
    Sleep(1000);
    Application.Terminate;

  end;
end;

procedure TFormHome.FormResize(Sender: TObject);
begin
  width_global := IntToStr(ClientWidth);
  height_global := IntToStr(ClientHeight + 6);
end;

end.
