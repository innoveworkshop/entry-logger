unit Main;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, Menus, StdCtrls,
  FormSpreadsheet, ELDocument;

type
  { TfrmMain }
  TfrmMain = class(TForm)
    mniSheet: TMenuItem;
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
    procedure mniSheetClick(Sender: TObject);

  private
    elDocument: TELDocument;
  public

  end;

var
  frmMain: TfrmMain;

implementation

{$R *.lfm}

{ TfrmMain }

{ Event for creating the main form. }
procedure TfrmMain.FormCreate(Sender: TObject);
begin
  txtConsole.Append('Welcome to Entry Logger!');

  elDocument := TELDocument.Create;
  txtConsole.Append(elDocument.ToString);
end;

{ Event for clicking the Sheet menu item. }
procedure TfrmMain.mniSheetClick(Sender: TObject);
begin
  frmSpreadsheet.Document := elDocument;
  frmSpreadsheet.Show;
end;

end.

