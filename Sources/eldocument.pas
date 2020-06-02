unit ELDocument;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Column;

type
  { TELDocument }
  TELDocument = class
    private
      FColumns: array of TColumn;
      function GetColumn(Index: Integer): TColumn;

    public
      property Column[Index: Integer]: TColumn read GetColumn;

      constructor Create; overload;

      function ColumnsLength: Integer;
      function ToString: String; override;
  end;

implementation

{ Constructs an empty Entry Logger Document. }
constructor TELDocument.Create;
var
  i: Integer;
begin
  { Construct and populate the array. }
  SetLength(FColumns, 10);
  for i := 0 to Length(FColumns) - 1 do
  begin
    FColumns[i] := TColumn.Create('Column ' + IntToStr(i));
  end;
end;

{ Gets a column from the array. }
function TELDocument.GetColumn(Index: Integer): TColumn;
begin
  GetColumn := FColumns[Index];
end;

{ Gets the length of the columns array. }
function TELDocument.ColumnsLength: Integer;
begin
  ColumnsLength := Length(FColumns);
end;

{ Gets a string representation of this object. }
function TELDocument.ToString: String;
var
  sBuffer: String;
  nIndex: Integer;
  colCurrent: TColumn;
begin
  { Go through the array of columns. }
  sBuffer := 'Columns:' + sLineBreak;
  for nIndex := 0 to Length(FColumns) - 1 do
  begin
    colCurrent := FColumns[nIndex];
    sBuffer := sBuffer + '    ' + colCurrent.Name + sLineBreak;
  end;

  ToString := sBuffer;
end;

end.

