pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/ChaimaSka/tp3-ci-tests.git'
            }
        }
        stage('Run .NET tests') {
            steps {
                dir('dotnet-app.Tests') {
                    bat 'dotnet test'
                }
            }
        }
        stage('Run Python tests') {
            steps {
                dir('python-app') {
                    bat '"C:\\Users\\skand\\AppData\\Local\\Programs\\Python\\Python311\\python.exe" -m pip install unittest-xml-reporting'
                    bat '"C:\\Users\\skand\\AppData\\Local\\Programs\\Python\\Python311\\python.exe" test_math_utils.py'
                }
            }
        }
    }
    post {
        always {
            echo 'Pipeline finished !!!'
        }
    }
}