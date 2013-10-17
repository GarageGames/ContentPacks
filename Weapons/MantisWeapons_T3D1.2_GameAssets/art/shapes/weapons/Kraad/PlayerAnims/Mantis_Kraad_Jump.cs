singleton TSShapeConstructor(Mantis_Kraad_JumpDAE)
{
   baseShape = "./Mantis_Kraad_Jump.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "800", "815", true, true);
}
