   // BEGIN: Kraad Sequences
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE run", "Kraad_run");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE run2sprint", "Kraad_run2sprint");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE sprint", "Kraad_sprint");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE sprint2run", "Kraad_sprint2run");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE idle", "Kraad_idle");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE idle_fidget1", "Kraad_idle_fidget1");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE fire", "Kraad_fire");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE reload", "Kraad_reload");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE switch_out", "Kraad_switch_out");
   %this.addSequence("art/shapes/weapons/Kraad/FP_Kraad.DAE switch_in", "Kraad_switch_in");
   
   %this.setSequenceCyclic("Kraad_fire", "0");
   %this.setSequenceCyclic("Kraad_reload", "0");
   %this.setSequenceCyclic("Kraad_switch_out", "0");
   %this.setSequenceCyclic("Kraad_switch_in", "0");
   %this.setSequenceCyclic("Kraad_run2sprint", "0");
   %this.setSequenceCyclic("Kraad_sprint2run", "0");
   %this.setSequenceCyclic("Kraad_idle_fidget1", "0");
   // END: Kraad Sequences
echo(" -- Kraad FP Animations Loaded");