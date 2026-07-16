# Attend
software attendance that manage school student attendance
=========================================================
git init
git add .
git status
git remote add origin https://github.com/meongar77/Attend.git
git config --global user.email "meongar77@gmail.com"
git config --global user.name "bikorimana louis"
git commit -m "Initial commit"
git pull origin main --allow-unrelated-histories
git push origin main



Entity framework

dotnet tool install --global dotnet-ef --version 10.0.0
dotnet ef migrations add InitialMigration --project ../Infrastructure/Infrastructure.csproj --startup-project ../Web/Web.csproj (For Every migration you change the name of file)
dotnet ef database update --project ../Infrastructure/Infrastructure.csproj --startup-project ../Web/Web.csproj