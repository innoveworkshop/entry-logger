unit FormSpreadsheet;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, Grids, ELDocument;

type
  { TfrmSpreadsheet }
  TfrmSpreadsheet = class(TForm)
    grdSheet: TStringGrid;
  private
    elDocument: TELDocument;

    procedure SetDocument(Document: TELDocument);

  public
    property Document: TELDocument read elDocument write SetDocument;

    procedure UpdateGridWithDocument;
  end;

var
  frmSpreadsheet: TfrmSpreadsheet;

implementation

{$R *.lfm}

{ Updates the grid with information from the associated document. }
procedure TfrmSpreadsheet.UpdateGridWithDocument;
var
  nIndex: Integer;
  colCurrent: TGridColumn;
begin
  { Populate the columns. }
  grdSheet.Columns.Clear;
  for nIndex := 0 to elDocument.ColumnsLength - 1 do
  begin
    colCurrent := grdSheet.Columns.Add;
    colCurrent.Title.Caption := elDocument.Column[nIndex].Name;
  end;
end;

{ Sets the Entry Logger Document for this form. }
procedure TfrmSpreadsheet.SetDocument(Document: TELDocument);
begin
  elDocument := Document;
  UpdateGridWithDocument;
end;

end.

