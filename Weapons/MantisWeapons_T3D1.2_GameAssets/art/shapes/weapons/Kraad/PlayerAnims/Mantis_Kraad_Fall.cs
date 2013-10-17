singleton TSShapeConstructor(Mantis_Kraad_FallDAE)
{
   baseShape = "./Mantis_Kraad_Fall.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "860", "879", true, true);
}
