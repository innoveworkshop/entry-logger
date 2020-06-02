unit Column;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils;

type
  { TColumn }
  TColumn = class
    private
      FName: String;

    public
      property Name: String read FName write FName;

      constructor Create(_name: String); overload;
  end;

implementation

{ Constructor that automatically sets the column name. }
constructor TColumn.Create(_name: String);
begin
  self.Name := _name;
end;

end.

