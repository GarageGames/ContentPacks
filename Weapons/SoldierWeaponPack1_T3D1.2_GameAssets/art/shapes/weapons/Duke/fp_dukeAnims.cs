   // BEGIN: Duke Sequences
   // Extracted from Duke
   %this.addSequence("./FP_Duke.DAE fire", "Duke_fire");
   %this.addSequence("./FP_Duke.DAE idle", "Duke_idle");
   %this.addSequence("./FP_Duke.DAE reload", "Duke_reload");
   %this.addSequence("./FP_Duke.DAE run", "Duke_run");
   %this.addSequence("./FP_Duke.DAE run2sprint", "Duke_run2sprint");
   %this.addSequence("./FP_Duke.DAE sprint", "Duke_sprint");
   %this.addSequence("./FP_Duke.DAE sprint2run", "Duke_sprint2run");
   %this.addSequence("./FP_Duke.DAE switch_in", "Duke_switch_in");
   %this.addSequence("./FP_Duke.DAE switch_out", "Duke_switch_out");
   
   %this.setSequenceCyclic( "Duke_fire", false );
   %this.setSequenceCyclic( "Duke_idle", true );
   %this.setSequenceCyclic( "Duke_reload", false );
   %this.setSequenceCyclic( "Duke_run", true );
   %this.setSequenceCyclic( "Duke_run2sprint", false );
   %this.setSequenceCyclic( "Duke_sprint", true );
   %this.setSequenceCyclic( "Duke_sprint2run", false );
   %this.setSequenceCyclic( "Duke_switch_in", false );
   %this.setSequenceCyclic( "Duke_switch_out", false );
   // END: General Duke Sequences
   
   echo(" -- Duke FP Animations Loaded");