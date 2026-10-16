# 산업용 로봇 작업 관제 및 관리 시뮬레이션 시스템

<p align="center">
  <strong>WPF로 구현하는 산업용 로봇 작업 관제 데스크톱 애플리케이션</strong><br/>
  기획 문서를 기준으로 화면과 기능을 단계적으로 설계·구현하는 개인 학습 프로젝트입니다.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-.NET%20Framework%204.7.2-512BD4?logo=dotnet&logoColor=white" alt="C# and .NET Framework"/>
  <img src="https://img.shields.io/badge/WPF-XAML-0078D4?logo=windows&logoColor=white" alt="WPF"/>
  <img src="https://img.shields.io/badge/Database-Oracle%20(planned)-F80000?logo=oracle&logoColor=white" alt="Oracle planned"/>
  <img src="https://img.shields.io/badge/Status-In%20Progress-orange" alt="In progress"/>
</p>

## 프로젝트 소개

로봇의 상태와 작업을 한 화면에서 관리하고, 작업 배정·진행·알람·이력을 확인하는 데스크톱 시스템을 목표로 합니다. 현재는 WPF/XAML 화면 구조와 공통 UI를 구성하며 화면 단위로 프로젝트를 확장하고 있습니다.

| 항목 | 내용 |
|---|---|
| 유형 | 개인 학습·포트폴리오 프로젝트 |
| 클라이언트 | Windows 데스크톱 |
| UI 기술 | C#, WPF, XAML |
| 데이터베이스 | Oracle Database 연동 예정 |
| 설계 자료 | [기획 문서와 화면 설계](1.%20PlanningDocs/) |

## 메인 대시보드 기획 시안

아래 이미지는 구현 화면이 아닌 기획 단계의 화면 시안입니다.

![메인 대시보드 기획 시안](1.%20PlanningDocs/0.Image/UI%EB%A9%94%EC%9D%B8%EB%8C%80%EC%8B%9C%EB%B3%B4%EB%93%9C.png)

## 화면 구성

| 화면 | View |
|---|---|
| 메인 대시보드 | `DashboardView` |
| 로봇 관리 | `RobotManagementView` |
| 작업 관리 | `TaskManagementView` |
| 작업 관제 | `TaskControlView` |
| 알람 관리 | `AlarmManagementView` |
| 이력 조회 | `HistoryView` |

각 화면은 별도의 WPF `UserControl`로 분리하고 `MainWindow`의 콘텐츠 영역에서 전환하도록 구성합니다. 공통 헤더와 로그인 창을 별도 파일로 관리해 화면 구조를 익히면서 재사용 UI를 정리하고 있습니다.

## 현재 구현 범위

- 로그인 화면과 메인 화면으로 이어지는 기본 흐름
- 공통 헤더와 메인 화면의 내비게이션 구조
- 대시보드 및 관리 화면별 View 파일 분리
- 여러 화면에서 공유할 WPF 스타일 리소스 구성 중

로봇 데이터 연동, 실제 작업 처리, 알람 생성과 Oracle 연결은 후속 구현 범위입니다. 화면 시안과 현재 구현 상태를 구분해 관리합니다.

## 기술 스택

- C#
- WPF / XAML
- .NET Framework 4.7.2
- Oracle Database 연동 예정
- MVVM 구조 단계적 적용 예정

## 실행 방법

1. Visual Studio에서 `2. SourceCode/RobotMonitoringSystem/RobotMonitoringSystem.csproj`를 엽니다.
2. .NET Framework 4.7.2 개발자 팩을 설치합니다.
3. 프로젝트를 빌드하고 실행합니다.
4. 현재 로그인 화면 확인용 값은 아이디 `root`, 비밀번호 `root`입니다.

> `root/root`는 개발 중 화면 확인을 위한 임시 값이며 실제 인증이나 보안 기능이 아닙니다.

## 프로젝트 구조

```text
.
├─ 1. PlanningDocs/
│  ├─ 0.Image/                         # UI·시스템·DB 설계 이미지
│  └─ 산업용 로봇 작업 관제 기획문서
└─ 2. SourceCode/
   └─ RobotMonitoringSystem/
      ├─ App.xaml                       # 애플리케이션 시작 설정
      ├─ LoginWindow.xaml               # 로그인 화면
      ├─ MainWindow.xaml                # 공통 프레임과 화면 전환
      ├─ CommonHeader.xaml              # 공통 헤더
      ├─ DashboardView.xaml             # 대시보드
      ├─ RobotManagementView.xaml       # 로봇 관리
      ├─ TaskManagementView.xaml        # 작업 관리
      ├─ TaskControlView.xaml           # 작업 관제
      ├─ AlarmManagementView.xaml       # 알람 관리
      ├─ HistoryView.xaml               # 이력 조회
      └─ Themes/                        # 공통 스타일 리소스
```

## 문서

- [프로젝트 기획 문서](1.%20PlanningDocs/산업용%20로봇%20작업%20관제%20및%20관리%20시뮬레이션%20시스템%20기획문서.pdf)
- [전체 시스템 구성도](1.%20PlanningDocs/0.Image/전체%20시스템%20구성도.png)
- [MVVM 구조도](1.%20PlanningDocs/0.Image/MVVM%EA%B5%AC%EC%A1%B0%EB%8F%84.png)
- [데이터베이스 ERD](1.%20PlanningDocs/0.Image/데이터베이스ERD.png)

---

기획 문서를 기준으로 UI, MVVM, 데이터 접근 계층을 학습하고 구현해 나가는 프로젝트입니다.
