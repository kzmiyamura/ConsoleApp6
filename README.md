# ConsoleApp6

## 概要
`ConsoleApp6` は、C# コンソールアプリケーションで作成した簡単な計算アプリです。  
ユーザーが入力した 2 つの数字を足し算して結果を表示する機能があります。

このプロジェクトは **Visual Studio と GitHub を使った開発の練習用** でもあります。

---

## 機能
- 2 つの整数を入力して足し算を行う
- 計算処理は別クラス `Calculator` に分離
- 入力値の検証（数字以外の入力時のエラー処理）
- 結果の表示

---

## フォルダ構成
ConsoleApp6/
├─ ConsoleApp6.sln
├─ ConsoleApp6/
│ ├─ Program.cs ← エントリーポイント（ユーザー入力）
│ ├─ Calculator.cs ← 計算処理クラス
│ └─ Properties/
│ └─ AssemblyInfo.cs
├─ .gitignore ← Gitで無視するファイル設定
└─ README.md

yaml
コードをコピーする

---

## 開発環境
- Visual Studio 2022
- C# 10
- .NET 6

---

## 実行方法
1. Visual Studio で `ConsoleApp6.sln` を開く
2. `Program.cs` を実行
3. コンソールに従って 2 つの整数を入力すると、計算結果が表示される

---

## GitHub 管理
- `.gitignore` を設定済みで、不要なビルドファイルや VS 固有ファイルは管理対象外
- コミット例：
  - `初期コミット`（プロジェクト作成）
  - `Calculatorクラス追加`
  - `計算機能完成`
  - `README.md 追加`

---

💡 **補足**  
- 今回のプロジェクトはコンソールアプリの基本的な設計を学ぶことが目的です。  
- さらに複雑なアプリやサービス層分離の練習は次の `ConsoleApp7` で行います。






