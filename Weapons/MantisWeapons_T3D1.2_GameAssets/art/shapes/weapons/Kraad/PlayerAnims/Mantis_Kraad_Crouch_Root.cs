singleton TSShapeConstructor(Mantis_Kraad_Crouch_RootDAE)
{
   baseShape = "./Mantis_Kraad_Crouch_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_Crouch_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Root", "580", "639", true, true);
}
