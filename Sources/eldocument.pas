unit ELDocument;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Column, Row;

type
  { TELDocument }
  TELDocument = class
    private
      FColumns: array of TColumn;
      FRows: array of TRow;

      function GetColumn(Index: Integer): TColumn;
      function GetRow(Index: Integer): TRow;

    public
      property Column[Index: Integer]: TColumn read GetColumn;
      property Row[Index: Integer]: TRow read GetRow;

      constructor Create; overload;

      function ColumnsLength: Integer;
      function RowsLength: Integer;
      function ToString: String; override;
  end;

implementation

{ Constructs an empty Entry Logger Document. }
constructor TELDocument.Create;
var
  i, j: Integer;
begin
  { Construct and populate the column array. }
  SetLength(FColumns, 3);
  for i := 0 to Length(FColumns) - 1 do
  begin
    FColumns[i] := TColumn.Create('Column ' + IntToStr(i));
  end;

  { Construct and populate the row array. }
  SetLength(FRows, 10);    
  for i := 0 to Length(FRows) - 1 do
  begin
    FRows[i] := TRow.Create;

    for j := 0 to Length(FColumns) - 1 do
    begin
      FRows[i].Add('Row ' + IntToStr(i) + ' Col ' + IntToStr(j));
    end;
  end;
end;

{ Gets the length of the columns array. }
function TELDocument.ColumnsLength: Integer;
begin
  ColumnsLength := Length(FColumns);
end;

{ Gets the length of the rows array. }
function TELDocument.RowsLength: Integer;
begin
  RowsLength := Length(FRows);
end;

{ Gets a column from the column array. }
function TELDocument.GetColumn(Index: Integer): TColumn;
begin
  GetColumn := FColumns[Index];
end;

{ Gets a row from the row array. }
function TELDocument.GetRow(Index: Integer): TRow;
begin
  GetRow := FRows[Index];
end;

{ Gets a string representation of this object. }
function TELDocument.ToString: String;
var
  sBuffer: String;
  nIndex: Integer;
  colCurrent: TColumn;
  rowCurrent: TRow;
begin
  { Go through the array of columns. }
  sBuffer := 'Columns:' + sLineBreak;
  for nIndex := 0 to Length(FColumns) - 1 do
  begin
    colCurrent := FColumns[nIndex];
    sBuffer := sBuffer + '    ' + colCurrent.Name + sLineBreak;
  end;

  { Go through the array of rows. }
  sBuffer := sBuffer + sLineBreak + 'Rows:' + sLineBreak;
  for nIndex := 0 to Length(FRows) - 1 do
  begin
    rowCurrent := Row[nIndex];
    sBuffer := sBuffer + '    ' + rowCurrent.ToString + sLineBreak;
  end;

  ToString := sBuffer;
end;

end.

