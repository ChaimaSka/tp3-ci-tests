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
                    bat 'python -m pip install unittest-xml-reporting'
                    bat 'python test_math_utils.py'
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