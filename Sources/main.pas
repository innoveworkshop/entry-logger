unit Main;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, Menus, Grids, StdCtrls;

type

  { TfrmMain }

  TfrmMain = class(TForm)
    txtConsole: TMemo;
    mnuWindow: TMenuItem;
    mniModel: TMenuItem;
    mnuFile: TMenuItem;
    mniNew: TMenuItem;
    mniOpen: TMenuItem;
    mniSave: TMenuItem;
    mniSaveAs: TMenuItem;
    mniExit: TMenuItem;
    N1: TMenuItem;
    mnuMain: TMainMenu;
    procedure FormCreate(Sender: TObject);
  private

  public

  end;

var
  frmMain: TfrmMain;

implementation

{$R *.lfm}

{ TfrmMain }

{ Form created event. }
procedure TfrmMain.FormCreate(Sender: TObject);
begin
  txtConsole.Append('Welcome to Entry Logger!');
end;

end.

