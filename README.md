# Disownership-paradigm-thresholds

## Unity project for stimulating own-body disownership (so-called long real hand illusion) through various repetitions of different delay steps. For the long-stimulation version, please refer to: https://github.com/marteroel/Disownership-paradigm-long . This project includes a setup GUI, delays webcam feed and uses VAS and forced choice questionnaires on a VR headset. It should be modified in order to implement similar setups.

IMPORTANT: DO NOT COMMIT TO THE MAIN BRANCH WITHOUT PREVIOUS AUTHORIZATION.

The Unity project includes the following scenes in English.

   - Intro: includes GUI for general settings and for participant's information (webcam input, serial port, condition duration, and other selections). A future update should allow users to setup number and name of conditions.

   - Instructions: includes the general instructions for the experiment and a short test of the use of the VAS. The instructions should be input directly on the scene by the experimenter.

   - StimulationTest: a short trial of how the stimulation will look (without delay) for participants to prepare.

   - Inter: the instructions for the specific condition to come (i.e. your hand will be stroked for a few seconds before you have to answer two questions). The instructions should be input directly on the scene by the experimenter.

   - Stimulation: the actual stimulation, it reads from the ‘Intro’ scene configurations such as delay steps, number of repetitions for each step, duration, and additional settings.
   
   - ForcedChoice: the questionnaire that will be presented in the VR headset for particpants. To change the questionnaire edit the questions_forced.csv file located in /Disownership paradigm Unity/Lists/ for Unity Editor mode or in /Lists (you have to create the directory yourself) for standalone mode. The data is logged under /Disownership paradigm Unity/Logs/ for Unity Editor mode or in /Logs (you have to create the directory yourself) for standalone mode. The Log file uses the participant ID as a name.

   - VAS: the questionnaire that will be presented in the VR headset for particpants. To change the questionnaire edit the questions.csv file located in /Disownership paradigm Unity/Lists/ for Unity Editor mode or in /Lists (you have to create the directory yourself) for standalone mode. The data is logged under /Disownership paradigm Unity/Logs/ for Unity Editor mode or in /Logs (you have to create the directory yourself) for standalone mode. The Log file uses the participant ID as a name.

   - Goodbye: simple UI thanking subjects for their participation.

Technical notes:

    Tested with the Oculus Rift CV1

    Running on Unity 2018.2.8f1

    Uses the following Unity packages: extOSC, VRStandardAssets (Unity) and modified versions of SimpleWebcamDelay (BSP Lab), Simple VAS VR (BSP Lab), Serial Messenger (BSP Lab)
