unit Main;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, Menus, Grids;

type

  { TfrmMain }

  TfrmMain = class(TForm)
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
    StringGrid1: TStringGrid;
    procedure mniSaveAsClick(Sender: TObject);
  private

  public

  end;

var
  frmMain: TfrmMain;

implementation

{$R *.lfm}

{ TfrmMain }

procedure TfrmMain.mniSaveAsClick(Sender: TObject);
begin

end;

end.

