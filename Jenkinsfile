pipeline{
  agent any
      stages {
         stage ('Compile Stage'){
            steps{
                sh 'export CUSTOM_VERSION=$(cat version.txt)'
            }
         }
         stage ('Testing'){
            steps {
              sh 'echo Test passed'
            }       
         }
        stage ('Deployment_to_Dev') {
            steps {
              hygieiaArtifactPublishStep artifactDirectory: '', artifactGroup: 'poc.app1', artifactName: '*.html', artifactVersion: '1.0.0.$CUSTOM_VERSION'
              hygieiaDeployPublishStep artifactDirectory: '', artifactGroup: 'poc.app1', artifactName: '*.html', artifactVersion: '1.0.0.$CUSTOM_VERSION', environmentName: 'Development', applicationName: 'App2'
            }
        }
     }
}
