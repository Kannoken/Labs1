unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ComCtrls;

type
  TForm1 = class(TForm)
    Edit1: TEdit;
    Memo1: TMemo;
    Label1: TLabel;
    Label2: TLabel;
    Edit3: TEdit;
    Label3: TLabel;
    UpDown1: TUpDown;
    UpDown3: TUpDown;
    Edit4: TEdit;
    UpDown4: TUpDown;
    procedure UpDown1Changing(Sender: TObject; var AllowChange: Boolean);
    procedure FormActivate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}
uses Unit2;
procedure TForm1.FormActivate(Sender: TObject);
begin
form2.Width:=700;
form2.Height:=500;
end;

procedure TForm1.UpDown1Changing(Sender: TObject; var AllowChange: Boolean);
var
l,x,y,s:integer;
a,p:real;
begin
form2.Canvas.FillRect(form2.Canvas.ClipRect);
x:=700 div 2;
y:=500-50;
form2.Canvas.Pen.Color:=clgreen;
l:=strtoint(form1.Edit1.Text);
form2.Visible:=true;
s:=strtoint(form1.Edit3.Text);
p:=strtoint(form1.Edit4.Text)*pi/180;
form2.tree(x,y,pi/2,p,l,s);
end;

end.
