unit Row;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

type
  { TRow }
  TRow = class(TStringList)
    public
      function AsArray: TStringArray;

      function Add(Value: Integer): Integer; overload;
      function Add(Value: Double): Integer; overload;

      function ToString: String; override;
  end;

implementation

{ Returns this row as an array of strings. }
function TRow.AsArray: TStringArray;
var
  arr: array of String;
  nIndex: Integer;
begin
  SetLength(arr, self.Count);

  for nIndex := 0 to self.Count - 1 do
  begin
    arr[nIndex] := self.Strings[nIndex];
  end;

  AsArray := arr;
end;

{ Adds row caption based on a integer value. }
function TRow.Add(Value: Integer): Integer;
begin
  Add := Add(IntToStr(Value));
end;

{ Adds row caption based on a float value. }
function TRow.Add(Value: Double): Integer;
begin
  Add := Add(FloatToStr(Value));
end;

{ A string representation of the object. }
function TRow.ToString: String;
var
  nIndex: Integer;
  sBuffer: String;
begin
  sBuffer := '[ ';

  for nIndex := 0 to self.Count - 1 do
  begin
    sBuffer := sBuffer + self.Strings[nIndex];

    if nIndex < (self.Count - 1) then
       sBuffer := sBuffer + ', ';
  end;

  sBuffer := sBuffer + ' ]';
  ToString := sBuffer;
end;

end.

