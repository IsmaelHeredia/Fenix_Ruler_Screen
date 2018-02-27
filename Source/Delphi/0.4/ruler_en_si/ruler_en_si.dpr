program ruler_en_si;

uses
  Forms,
  paspas in 'paspas.pas' {FormHome};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'Screen RULER';
  Application.CreateForm(TFormHome, FormHome);
  Application.Run;
end.
