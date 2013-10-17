   // BEGIN: Kral Sequences
   %seqPrefix = "Kral_";
   %this.addSequence( "./Mantis_Kral_Back.dae Back", "Kral_Back", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Crouch_Forward.dae Crouch_Forward", "Kral_Crouch_Forward", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Crouch_Side.dae Crouch_Side", "Kral_Crouch_Side", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Crouch_Root.dae Crouch_Root", "Kral_Crouch_Root", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Death1.dae Death1", "Kral_Death1", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Fall.dae Fall", "Kral_Fall", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Head.dae Head", "Kral_Head", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Jump.dae Jump", "Kral_Jump", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Land.dae Land", "Kral_Land", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Look.dae Look", "Kral_Look", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Root.dae Root", "Kral_Root", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Run.dae Run", "Kral_Run", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Sprint.dae Sprint", "Kral_Sprint_Forward", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Side.dae Side", "Kral_Side", 0, -1, true, true);
   %this.addSequence( "./Mantis_Kral_Reload.dae Reload", "Kral_Reload", 0, -1, true, true);
   
   %this.setSequenceCyclic( "Kral_Back", true);
   %this.setSequenceCyclic( "Kral_Crouch_Forward", true);
   %this.setSequenceCyclic( "Kral_Crouch_Side", true);
   %this.setSequenceCyclic( "Kral_Crouch_Root", true);
   %this.setSequenceCyclic( "Kral_Death1", false);
   %this.setSequenceCyclic( "Kral_Fall", true);
   %this.setSequenceCyclic( "Kral_Head", false);
   %this.setSequenceCyclic( "Kral_Jump", false);
   %this.setSequenceCyclic( "Kral_Land", false);
   %this.setSequenceCyclic( "Kral_Look", false);
   %this.setSequenceCyclic( "Kral_Root", true);
   %this.setSequenceCyclic( "Kral_Run", true);
   %this.setSequenceCyclic( "Kral_Sprint", true);
   %this.setSequenceCyclic( "Kral_Side", true);
   %this.setSequenceCyclic( "Kral_Reload", false);

   %this.setSequenceBlend( "Kral_Head", "1", "Kral_Root", "0");
   %this.setSequenceBlend( "Kral_Look", "1", "Kral_Root", "0");
   %this.setSequenceBlend( "Kral_Reload", "1", "Kral_Root", "0");
   // END: Kral Sequences
   echo(" -- Kral Animations Loaded");