:: �������ַ���
echo %1
:: ��Ŀ������ַ
echo %2

:: ɾ����ʷ��
del %1 /f /q /a 

:: ������
set nupkg=""

:: ����
dotnet msbuild %2 /p:Configuration=Release

:: ���
dotnet pack %2 -c Release --output ../tools/nupkgs

:: ���°�����
for %%a in (dir /s /a /b "./nupkgs/%1") do (set nupkg=%%a)

:: ���Ͱ�
nuget push nupkgs/%nupkg% oy2ofmt4bb5ejmab7czasmy6u3xw2ekevoxlo46levhdv4 -Source https://www.nuget.org/api/v2/package