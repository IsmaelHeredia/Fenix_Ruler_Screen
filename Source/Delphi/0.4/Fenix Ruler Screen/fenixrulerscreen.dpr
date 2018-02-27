program fenixrulerscreen;

uses
  Vcl.Forms,
  ruler in 'ruler.pas' {FormHome},
  Vcl.Themes,
  Vcl.Styles;

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  TStyleManager.TrySetStyle('Orange Graphite');
  Application.CreateForm(TFormHome, FormHome);
  Application.Run;
end.
