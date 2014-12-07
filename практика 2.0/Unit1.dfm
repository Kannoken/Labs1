object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 358
  ClientWidth = 430
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = 'Segoe UI'
  Font.Style = []
  OldCreateOrder = False
  OnActivate = FormActivate
  PixelsPerInch = 96
  TextHeight = 15
  object Label1: TLabel
    Left = 32
    Top = 155
    Width = 80
    Height = 15
    Caption = #1042#1099#1089#1086#1090#1072' '#1089#1090#1074#1086#1083#1072
  end
  object Label2: TLabel
    Left = 40
    Top = 254
    Width = 108
    Height = 15
    Caption = #1059#1075#1086#1083' '#1085#1072#1082#1083#1086#1085#1072' '#1074#1077#1090#1074#1080
  end
  object Label3: TLabel
    Left = 32
    Top = 206
    Width = 129
    Height = 15
    Caption = #1057#1086#1086#1090#1085#1086#1096#1077#1085#1080#1077' '#1074#1077#1090#1086#1082'(%)'
  end
  object Edit1: TEdit
    Left = 176
    Top = 152
    Width = 121
    Height = 23
    TabOrder = 0
    Text = '100'
  end
  object Memo1: TMemo
    Left = 72
    Top = 8
    Width = 273
    Height = 106
    Lines.Strings = (
      #1055#1088#1086#1075#1088#1072#1084#1084#1072' '#1089#1090#1088#1086#1080#1090' '#1092#1088#1072#1082#1090#1072#1083#1100#1085#1086#1077' '#1076#1077#1088#1077#1074#1086' '#1089' '
      #1079#1072#1076#1072#1085#1085#1099#1084#1080' '#1087#1072#1088#1072#1084#1077#1090#1088#1072#1084#1080'. '
      #1055#1086#1083#1100#1079#1086#1074#1072#1090#1077#1083#1100' '#1074#1074#1086#1076#1080#1090#1100' '#1085#1072#1095#1072#1083#1100#1085#1099#1077' '#1087#1072#1088#1072#1084#1077#1090#1088#1099' '
      #1090#1072#1082#1080#1077' '#1082#1072#1082': '#1074#1099#1089#1086#1090#1072' '#1089#1090#1074#1086#1083#1072', '#1091#1075#1086#1083' '#1085#1072#1082#1083#1086#1085#1072' '#1074#1077#1090#1074#1080', '
      #1089#1086#1086#1090#1085#1086#1096#1077#1085#1080#1077' '#1076#1083#1080#1085#1099' '#1074#1077#1090#1086#1082)
    TabOrder = 1
  end
  object Edit3: TEdit
    Left = 176
    Top = 203
    Width = 121
    Height = 23
    TabOrder = 2
    Text = '70'
  end
  object UpDown1: TUpDown
    Left = 297
    Top = 152
    Width = 16
    Height = 23
    Associate = Edit1
    Max = 200
    Position = 100
    TabOrder = 3
    OnChanging = UpDown1Changing
  end
  object UpDown3: TUpDown
    Left = 297
    Top = 203
    Width = 16
    Height = 23
    Associate = Edit3
    Max = 86
    Position = 70
    TabOrder = 4
    OnChanging = UpDown1Changing
  end
  object Edit4: TEdit
    Left = 176
    Top = 251
    Width = 121
    Height = 23
    TabOrder = 5
    Text = '70'
  end
  object UpDown4: TUpDown
    Left = 297
    Top = 251
    Width = 16
    Height = 23
    Associate = Edit4
    Min = 1
    Position = 70
    TabOrder = 6
    OnChanging = UpDown1Changing
  end
end
