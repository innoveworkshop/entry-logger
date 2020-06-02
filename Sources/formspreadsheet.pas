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

    procedure SetDocument(elDoc: TELDocument);

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
  nCurrentRow: Integer;
  colCurrent: TGridColumn;
begin
  { Prepare the grid to accept data. }
  grdSheet.ClearCols;
  grdSheet.RowCount := 1;

  { Populate the columns. }
  for nIndex := 0 to elDocument.ColumnsLength - 1 do
  begin
    colCurrent := grdSheet.Columns.Add;
    colCurrent.Title.Caption := elDocument.Column[nIndex].Name;
  end;

  { Populate the rows with data. }
  nCurrentRow := grdSheet.RowCount;
  for nIndex := 0 to elDocument.RowsLength - 1 do
  begin
    grdSheet.RowCount := nCurrentRow + 1;
    grdSheet.InsertRowWithValues(nCurrentRow, elDocument.Row[nIndex].AsArray);
    nCurrentRow := nCurrentRow + 1;
  end;
end;

{ Sets the Entry Logger Document for this form. }
procedure TfrmSpreadsheet.SetDocument(elDoc: TELDocument);
begin
  elDocument := elDoc;
  UpdateGridWithDocument;
end;

end.

