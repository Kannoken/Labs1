unit Unit2;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs;

type
  TForm2 = class(TForm)
  procedure tree(x,y:integer; a,p:real; l:integer;s:integer);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

{$R *.dfm}

uses Unit1;

  procedure Tform2.tree(x,y:integer; a,p:real; l:integer;s:integer);
  var
  x1,y1,i,x2,y2:integer;
Begin
  if l<10 then
        exit
  else
  begin
    if (l<25)and (l>=10) then
    form2.Canvas.Pen.Color:=clgreen
    else
    form2.Canvas.Pen.Color:=clMaroon;
    form2.Canvas.Pen.Width:=(l div 8);
    form2.Canvas.MoveTo(x,y);
    x1:=round(x+l*cos(a));
    y1:=round(y-l*sin(a));
    x2:=round(x+(l div 2)*cos(a));
    y2:=round(y-(l div 2)*sin(a));
    form2.Canvas.LineTo(round(x1), round(y1));
    form2.tree(x1,y1,a-p,p,round(l*(s/100)),s);
    form2.tree(x1,y1,a+p,p,round(l*(s/100)),s);
    form2.tree(x2,y2,a-p,p,round(l*(s/100)),s);
    form2.tree(x2,y2,a+p,p,round(l*(s/100)),s);
  end;
end;

end.
