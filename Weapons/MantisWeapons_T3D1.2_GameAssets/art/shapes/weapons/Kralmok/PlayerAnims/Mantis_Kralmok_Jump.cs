singleton TSShapeConstructor(Mantis_Kralmok_JumpDAE)
{
   baseShape = "./Mantis_Kralmok_Jump.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "800", "815", true, true);
}
